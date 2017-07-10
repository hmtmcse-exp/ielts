package com.hmtmcse.html;


import com.hmtmcse.common.AppExceptionHandler;
import com.hmtmcse.common.Constant;
import com.hmtmcse.common.Log;
import com.hmtmcse.common.MyFileWriter;
import com.hmtmcse.data.Analyze;
import com.hmtmcse.data.TokenList;
import com.hmtmcse.data.Tokens;
import com.hmtmcse.db.SQLiteExceptionHandler;
import com.hmtmcse.db.SQLiteSQLQueryHelper;
import com.hmtmcse.es.ESManager;
import org.codehaus.jackson.map.DeserializationConfig;
import org.codehaus.jackson.map.ObjectMapper;
import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.select.Elements;

import java.io.IOException;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Date;
import java.util.UUID;

/**
 * Created by touhid on 18/07/2016.
 */
public class IELTSMentor {



    public static void main(String[] args) {
        try {

            String webURL = "http://www.ielts-mentor.com/reading-sample/academic-reading/26-ielts-academic-reading-sample-1-population-viability-analysis";
            String topicName = "Population Viability Analysis";
            String groupName = "READING";
            String uniqueName = topicName.replaceAll("[\\s*.-]", "_").toLowerCase();
            uniqueName = uniqueName.replaceAll("[^a-zA-Z0-9_]", "");


            Document document = Jsoup.connect(webURL).get();
            Elements article = document.select("article");
            article.select("h2").get(0).remove();
            article.select("div").get(0).remove();
            article.select("div").get(0).remove();
            article.select("script").remove();
            article.select("p").get(0).remove();
            article.select("dl").remove();
            article.select(".pager").remove();
            article.select(".extravote").remove();
            article.select(".bt-social-share").remove();
            article.select("a").remove();
            article.select("#fb-root").remove();
            article.select(".adsbygoogle").remove().parents().remove();
            article.select("#jc").remove();
//            article.select("p:contains(visit)").remove();
          //  System.out.println(article);

            ObjectMapper mapper = new ObjectMapper();
            Analyze analyze = new Analyze();
            analyze.setAnalyzer("english");
            analyze.setText(article.text());

            ESManager esManager = new ESManager();
            esManager.INDEX_NAME = "word_note";
            String json = esManager.analyze(mapper.writeValueAsString(analyze));


            mapper = new ObjectMapper();
            mapper.configure(DeserializationConfig.Feature.FAIL_ON_UNKNOWN_PROPERTIES, false);
            TokenList result = mapper.readValue(json,TokenList.class);

            SQLiteSQLQueryHelper sqLiteSQLQueryHelper = new SQLiteSQLQueryHelper();
            String uuid =  UUID.randomUUID().toString();

            ResultSet resultSet = sqLiteSQLQueryHelper.select("note", "id",
                    "where name='" + topicName + "' AND note_group='" + groupName + "' AND reference='" + webURL + "'"
            );
            String noteId = "";
            while (resultSet.next()) {
                noteId = resultSet.getString("id");
            }

            if (noteId.equals("")){
                sqLiteSQLQueryHelper.insertInto("note","name,note_group,uuid,reference",
                        "'" + topicName + "'," +
                                "'" + groupName + "'," +
                                "'" + uuid + "'," +
                                "'" + webURL + "'"
                );

                resultSet = sqLiteSQLQueryHelper.select("note", "id", "where uuid='" + uuid + "'");
                noteId = "";
                while (resultSet.next()) {
                    noteId = resultSet.getString("id");
                }
            }

            uniqueName = noteId + "_" + uniqueName;
            sqLiteSQLQueryHelper.update("note", "name='" + topicName + "', identifier='" + uniqueName + "'","where id =" + noteId);

            StringBuilder translateWord = new StringBuilder();
            translateWord.append(System.getProperty("line.separator"));
            translateWord.append(System.getProperty("line.separator"));
            translateWord.append(System.getProperty("line.separator"));
            translateWord.append("=================================================");
            translateWord.append(System.getProperty("line.separator"));
            translateWord.append(new Date().toString());
            translateWord.append(System.getProperty("line.separator"));
            translateWord.append(topicName);
            translateWord.append(System.getProperty("line.separator"));
            translateWord.append(groupName);
            translateWord.append(System.getProperty("line.separator"));
            translateWord.append("=================================================");
            translateWord.append(System.getProperty("line.separator"));

            if (noteId.equals("")){
                Log.error("Note Id Not found.");
            }else{
                for(Tokens tokens : result.getTokens()){
                    if (tokens.getType() != null && tokens.getType().equals("<ALPHANUM>")){
                        String word = tokens.getToken();
                        if (word.length() > 1){
                            String wordId = "";
                            word = word.trim();
                            word = word.replace("'","");
                            Log.info(word);
                            resultSet = sqLiteSQLQueryHelper.select("word", "id", "where en='" + word + "'");
                            while (resultSet.next()) {
                                wordId = resultSet.getString("id");
                            }

                            if (wordId.equals("")){
                                uuid =  UUID.randomUUID().toString();
                                sqLiteSQLQueryHelper.insertInto("word","en,status,uuid",
                                        "'" + word + "'," +
                                                "" + 1 + "," +
                                                "'" + uuid + "'"
                                );

                                translateWord.append("|");
                                translateWord.append(word);
                                translateWord.append("|");
                                translateWord.append(System.getProperty("line.separator"));

                                resultSet = sqLiteSQLQueryHelper.select("word", "id", "where uuid='" + uuid + "'");
                                while (resultSet.next()) {
                                    wordId = resultSet.getString("id");
                                }
                            }

                            Boolean willMap = true;
                            resultSet = sqLiteSQLQueryHelper.select("word_note", "*", "where word_id=" + wordId + " AND note_id = " + noteId);
                            while (resultSet.next()) {
                                willMap = false;
                            }

                            if (willMap){
                                sqLiteSQLQueryHelper.insertInto("word_note","word_id,note_id",
                                        "" + wordId + "," +
                                                "" + noteId + ""
                                );
                                System.out.println("Insert: " + word + " : " + wordId + " : " + noteId);
                            }else{
                                System.out.println("Update: " + word + " : " + wordId + " : " + noteId);
                            }
                        }
                    }
                }
            }

            if (!translateWord.toString().equals("")){
                MyFileWriter.appendToFile(translateWord.toString(),"store/feature_file.txt");
                MyFileWriter.writeToFile(article.toString(), Constant.HTML_READ + uniqueName + ".html");
            }

            System.out.println("noteId: " + noteId);



        } catch (IOException e) {
            e.printStackTrace();
        } catch (AppExceptionHandler appExceptionHandler) {
            appExceptionHandler.printStackTrace();
        } catch (SQLiteExceptionHandler sqLiteExceptionHandler) {
            sqLiteExceptionHandler.printStackTrace();
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

}



