using IELTS_Helper.Database;
using IELTS_Helper.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IELTS_Helper.Service
{
    public class VocabularyService
    {
        public static List<WordModel> words = new List<WordModel>();
        public static List<ListViewItem> listViewItemList = new List<ListViewItem>();

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
