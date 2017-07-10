package com.hmtmcse.common;

import java.io.BufferedWriter;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.OutputStreamWriter;

/**
 * Created by touhid on 31/07/2016.
 */
public class MyFileWriter {

    public static void appendToFile(String line, String location){
        try {
            OutputStreamWriter writer = new OutputStreamWriter(new FileOutputStream(location, true), "UTF-8");
            BufferedWriter fbw = new BufferedWriter(writer);
            fbw.newLine();
            fbw.write(line);
            fbw.close();

        }
        catch (IOException e) {
            System.out.println("exception occoured"+ e);
        }
    }

    public static void writeToFile(String line, String location){
        try {
            OutputStreamWriter writer = new OutputStreamWriter(new FileOutputStream(location), "UTF-8");
            BufferedWriter fbw = new BufferedWriter(writer);
            fbw.newLine();
            fbw.write(line.trim());
            fbw.close();

        }
        catch (IOException e) {
            System.out.println("exception occoured"+ e);
        }
    }

    public static String toUpperFirst(String word) {
        if (word.equals("") || word == null){
            return "";
        }
        char first = Character.toUpperCase(word.charAt(0));
        return first + word.substring(1);
    }

    public static String commaToList(String word) {
        if (word.equals("") || word == null){
            return "";
        }
        String[] words = word.split(",");
        String list = "";
        String uWord;
        for (int i = 0; i < words.length; i++) {
            uWord = words[i];
            uWord =  MyFileWriter.toUpperFirst(uWord.trim());
            list += i + 1 + ". " +  uWord + "\n";
        }
        return list;
    }

}
