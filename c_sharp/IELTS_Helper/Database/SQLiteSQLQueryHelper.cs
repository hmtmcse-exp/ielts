using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IELTS_Helper.Database
{
    public class SQLiteSQLQueryHelper : SQLiteConnectionManager
    {

        public SQLiteSQLQueryHelper() : base()
        {

        }

        public void InsertInto(String table, String column, String values)
        {
            String sql = "INSERT INTO " + table + " ( " + column + " ) VALUES ( " + values + " )";
            ExecutorNonQuery("INSERT INTO", sql);
        }

        public void Update(String table, String pair, String condition)
        {
            String sql = "UPDATE " + table + " SET " + pair + " " + condition;
            ExecutorNonQuery("UPDATE", sql);
        }

        public void Delete(String table, String where)
        {
            String sql = "DELETE FROM " + table + " " + where;
            ExecutorNonQuery("DELETE FROM", sql);
        }

        public SQLiteDataReader Select(String table, String select, String condition)
        {
            String sql = "SELECT " + select + " FROM " + table + " " + (condition != null ? condition : "");
            return ExecutorReader("SELECT", sql);
        }


        public void CreateTable(String tableName, String tableFields)
        {
            String sql = "CREATE TABLE " + tableName + " ( " + tableFields + " )";
            ExecutorNonQuery("createTable", sql);
        }


        private void ExecutorNonQuery(String from, String sql)
        {
            sqLiteCommand.CommandText = sql;
            sqLiteCommand.ExecuteNonQuery();
        }

        private SQLiteDataReader ExecutorReader(String from, String sql)
        {
            sqLiteCommand.CommandText = sql;
            SQLiteDataReader reader = sqLiteCommand.ExecuteReader();
            return reader;
        }
    }
}
