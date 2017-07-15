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
        public static Dictionary<String, List<WordModel>> wordMap = new Dictionary<String, List<WordModel>>();
        public static Dictionary<String, List<ListViewItem>>  listViewItemMap = new Dictionary<String, List<ListViewItem>>();

        public SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        Thread thread = null;
        public static int lastReadIndex = 0;

        public VocabularyService()
        {
            speechSynthesizer.SetOutputToDefaultAudioDevice();
        }



        public void load(ListView listView)
        {
            loadFromDatabase(false);
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.Columns.Add("SL");
            listView.Columns.Add("English Word", 100);
            listView.Columns.Add("Bangla Meaning", 100);
            listView.Columns.Add("Parts of Speech", 100);
                          

            foreach (ListViewItem listViewItem in listViewItemList)
            {
                listView.Items.Add(listViewItem);
            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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

            if (playWordSettings.SynonymTextBox != null)
            {
                playWordSettings.SynonymTextBox.Text = wordModel.Synonym;
            }

            if (playWordSettings.ListView != null && playWordSettings.ExtraInt1 != -1)
            {
                playWordSettings.ListView.Items[playWordSettings.ExtraInt1].Selected = true;
                playWordSettings.ListView.Items[playWordSettings.ExtraInt1].Focused = true;
                playWordSettings.ListView.TopItem = playWordSettings.ListView.Items[playWordSettings.ExtraInt1];
                playWordSettings.ListView.Select();
            }
        }

        public void SpeakWord(String word)
        {
            speechSynthesizer.SpeakAsync(word);
        }

        public void PlayWordLoopBG(List<WordModel> wordList, PlayWordSettings playWordSettings)
        {
            for( int i = playWordSettings.StartIndex; i < wordList.Count(); i++)
            {
                WordModel wordModel = wordList[i];
                VocabularyService.lastReadIndex = i;
                if (wordModel.EnglishWord != null)
                {
                    if (playWordSettings.BackgroundToUITask && playWordSettings.Form != null)
                    {
                        playWordSettings.Form.Invoke
                            ((MethodInvoker) delegate
                            {
                                playWordSettings.ExtraInt1 = i;
                                UpdateUI(wordModel, playWordSettings);
                            }
                            );
                    }
                    speechSynthesizer.Speak(wordModel.EnglishWord);
                    VocabularyService.lastReadIndex++;
                    Thread.Sleep(1000 * playWordSettings.SpeechDelay);
                }
                else
                {
                    VocabularyService.lastReadIndex++;
                }
                
            }
        }

        public void PlayWords(List<WordModel> wordList, PlayWordSettings playWordSettings)
        {
            if(thread != null)
            {
                thread.Abort();
            }
            thread = new Thread(() => PlayWordLoopBG(wordList, playWordSettings));
            if (playWordSettings.WillRun)
            {
                thread.Start();
            }
            else
            {
                thread.Abort();
            }
            

        }

        private void loadFromDatabase(Boolean isReload)
        {
            if (isReload == false || words.Count() == 0)
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
                        wordModel.Synonym = reader["en_synonym"].ToString();
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

        public void LoadReadingListViewVocabulary(String noteId, ListView listView)
        {
            listView.Clear();
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.Columns.Add("SL");
            listView.Columns.Add("English", 100);
            listView.Columns.Add("Bangla", 100);

            LoadByNoteIdFromDatabase(noteId, AppConstant.READING, false);
            string modelKey = GetModelKey(noteId, AppConstant.READING);
            foreach (ListViewItem listViewItem in listViewItemMap[modelKey])
            {
                listView.Items.Add(listViewItem);
            }
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ReadingListViewWordMeaning(int numberOfWord, string modelKey, SQLiteDataReader reader)
        {
            string[] listViewItemArray = new string[5];
            listViewItemArray[0] = numberOfWord + "";
            listViewItemArray[1] = reader["en"].ToString();
            listViewItemArray[2] = reader["bd"].ToString();
            listViewItemMap[modelKey].Add(new ListViewItem(listViewItemArray));
        }


        public static string GetModelKey(String noteId, String mapKey)
        {
            return noteId + "_" + mapKey;
        }

        private void LoadByNoteIdFromDatabase(String noteId, String mapKey, Boolean isReload)
        {
            string modelKey = GetModelKey(noteId, mapKey);
            if (isReload == false || (wordMap[modelKey] != null && wordMap[modelKey].Count() != 0))
            {
                wordMap[modelKey] = new List<WordModel>();
                listViewItemMap[modelKey] = new List<ListViewItem>();
                try
                {
                SQLiteSQLQueryHelper sqLiteSQLQueryHelper = new SQLiteSQLQueryHelper();
                SQLiteDataReader reader = sqLiteSQLQueryHelper.ExecuteComplexSelect("*", "FROM word_note LEFT JOIN word ON word_note.word_id = word.id WHERE note_id = " + noteId + " ORDER BY word.en asc");

                WordModel wordModel;
                    int numberOfWord = 1;
                    while (reader.Read())
                {
                        wordModel = new WordModel();
                        wordModel.Id = reader["id"].ToString();
                        wordModel.EnglishWord = reader["en"].ToString();
                        wordModel.BanglaMeaning = reader["bd"].ToString();
                        wordModel.PartsOfSpeech = reader["en_ps"].ToString();
                        wordModel.Synonym =  reader["en_synonym"].ToString();
                        wordMap[modelKey].Add(wordModel);
                        ReadingListViewWordMeaning(numberOfWord, modelKey, reader);
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
