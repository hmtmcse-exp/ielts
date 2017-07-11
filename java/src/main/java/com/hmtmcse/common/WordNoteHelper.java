package com.hmtmcse.common;

import com.hmtmcse.db.SQLiteExceptionHandler;
import com.hmtmcse.db.SQLiteSQLQueryHelper;

import java.sql.ResultSet;
import java.sql.SQLException;

/**
 * Created by hmtmc on 11/07/2017.
 */
public class WordNoteHelper {

    public static Boolean willTranslated(String word){
        try {
            SQLiteSQLQueryHelper sqLiteSQLQueryHelper = new SQLiteSQLQueryHelper();
            ResultSet resultSet = sqLiteSQLQueryHelper.select("word", "id", "where en='" + word + "' and status = 1");
            while (resultSet.next()) {
               return true;
            }

        } catch (SQLiteExceptionHandler sqLiteExceptionHandler) {
            Log.error(sqLiteExceptionHandler.getMessage());
        } catch (SQLException e) {
            Log.error(e.getMessage());
        }
        return false;
    }
}
