using IELTS_Helper.Database;
using IELTS_Helper.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IELTS_Helper.Service
{
    public class VocabularyService
    {
        public static List<WordModel> words = new List<WordModel>();
        public static List<ListViewItem> listViewItemList = new List<ListViewItem>();
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        Thread thread = null;

        public void load(ListView listView)
        {
            loadFromDatabase(false);
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.Columns.Add("SL", 100);
            listView.Columns.Add("English Word", 100);
            listView.Columns.Add("Bangla Meaning", 100);
            listView.Columns.Add("Parts of Speech", 100);
            listView.Columns.Add("Synonym", 100);
            foreach(ListViewItem listViewItem in listViewItemList)
            {
                listView.Items.Add(listViewItem);
            }
        }


        public void UpdateUI(WordModel wordModel, PlayWordSettings playWordSettings)
        {
            if(playWordSettings.BanglaWordLabel != null)
            {
                playWordSettings.BanglaWordLabel.Text = wordModel.BanglaMeaning;
            }

            if (playWordSettings.EnglishWordLabel != null)
            {
                playWordSettings.EnglishWordLabel.Text = wordModel.EnglishWord;
            }

            if (playWordSettings.SynonymLabel != null)
            {
                playWordSettings.SynonymLabel.Text = wordModel.Synonym;
            }
        }

        public void PlayWordLoopBG(List<WordModel> wordList, PlayWordSettings playWordSettings)
        {
            speechSynthesizer.SetOutputToDefaultAudioDevice();
            foreach(WordModel wordModel in wordList)
            {
                if(wordModel.EnglishWord != null)
                {
                    if (playWordSettings.BackgroundToUITask && playWordSettings.Form != null)
                    {
                        playWordSettings.Form.Invoke
                            ((MethodInvoker) delegate
                            {
                                UpdateUI(wordModel, playWordSettings);
                            }
                            );
                    }
                    speechSynthesizer.Speak(wordModel.EnglishWord);
                    Thread.Sleep(1000 * playWordSettings.SpeechDelay);
                }
            }
        }

        public void PlayWords(List<WordModel> wordList, PlayWordSettings playWordSettings)
        {
            thread = new Thread(() => PlayWordLoopBG(wordList, playWordSettings));
            thread.Start();

        }

        private void loadFromDatabase(Boolean isReload)
        {
            if(isReload == false || words.Count() == 0)
            {
                words = new List<WordModel>();
                try
                {
                SQLiteSQLQueryHelper sqLiteSQLQueryHelper = new SQLiteSQLQueryHelper();
                SQLiteDataReader reader = sqLiteSQLQueryHelper.Select("word", "*", "ORDER BY en asc");

                WordModel wordModel;
                    int numberOfWord = 1;
                    while (reader.Read())
                {
                        string[] listViewItemArray = new string[5];
                        wordModel = new WordModel();
                        wordModel.Id = reader["id"].ToString();
                        wordModel.EnglishWord = listViewItemArray[1] = reader["en"].ToString();
                        wordModel.BanglaMeaning = listViewItemArray[2] = reader["bd"].ToString();
                        wordModel.PartsOfSpeech = listViewItemArray[3] = reader["en_ps"].ToString();
                        wordModel.Synonym = listViewItemArray[4] = reader["en_synonym"].ToString();                        
                        words.Add(wordModel);
                        listViewItemArray[0] = numberOfWord + "";
                        listViewItemList.Add(new ListViewItem(listViewItemArray));
                        numberOfWord++;
                    }
            }
            catch (SQLiteException sql)
            {
                    Console.WriteLine("Exception loadFromDatabase");
            }

            }
        }


    }
}
