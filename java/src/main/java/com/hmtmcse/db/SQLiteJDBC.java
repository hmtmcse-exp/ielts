package com.hmtmcse.db;

/**
 * Created by touhid on 03-Jul-17.
 */


public class SQLiteJDBC {


    public static void main( String args[] ) {
        try {
            SQLiteSQLQueryHelper sqLiteSQLQueryHelper = new SQLiteSQLQueryHelper();

            String tableRow = "id INTEGER PRIMARY KEY AUTOINCREMENT,";
            tableRow += "en text NOT NULL,";
            tableRow += "en_past text NULL,";
            tableRow += "en_past_participle text NULL,";
            tableRow += "en_plural text NULL,";
            tableRow += "bd text NULL,";
            tableRow += "en_ps text NULL,";
            tableRow += "en_synonym text NULL,";
            tableRow += "uuid text NULL,";
            tableRow += "status INTEGER NULL";
            sqLiteSQLQueryHelper.createTable("word", tableRow);

            tableRow = "id INTEGER PRIMARY KEY AUTOINCREMENT,";
            tableRow += "name text NOT NULL,";
            tableRow += "note_group text NOT NULL,";
            tableRow += "description text NULL,";
            tableRow += "uuid text NULL,";
            tableRow += "identifier text NULL,";
            tableRow += "reference text NULL";
            sqLiteSQLQueryHelper.createTable("note", tableRow);


            tableRow = "word_id INTEGER NOT NULL,";
            tableRow += "note_id INTEGER NOT NULL";
            sqLiteSQLQueryHelper.createTable("word_note", tableRow);


        } catch (SQLiteExceptionHandler sqLiteExceptionHandler) {
            System.out.println(sqLiteExceptionHandler.getMessage());
        }
    }
}
