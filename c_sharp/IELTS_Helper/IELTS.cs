using IELTS_Helper.Database;
using IELTS_Helper.Service;
using IELTS_Helper.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IELTS_Helper
{
    public partial class IELTS : Form
    {

        Boolean isStartTalking = false;
        VocabularyService vocabularyService = new VocabularyService();
        private WordModel tempWordModel = null;

        public IELTS()
        {
            InitializeComponent();
        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = CommonMark.CommonMarkConverter.Convert("**Hello world!**");
            introWeb.DocumentText = result;




            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void reading_Click(object sender, EventArgs e)
        {
            

        }

        private void introduction_TabIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void introduction_Click(object sender, EventArgs e)
        {
           
        }

        private void introduction_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void introduction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (introduction.SelectedTab.Name == "reading" && !StaticDataHolder.isReadingTabLoaded)
            {
                StaticDataHolder.isReadingTabLoaded = true;
                NoteService noteService = new NoteService();
                listBox1.DataSource = noteService.GetNotesByGroupName(AppConstant.READING);
                listBox1.DisplayMember = "DisplayName";
                listBox1.ValueMember = "Identifier";

            }
            else if (introduction.SelectedTab.Name == "vocabulary" && !StaticDataHolder.isVocabularyTabLoaded)
            {
                StaticDataHolder.isVocabularyTabLoaded = true;
                vocabularyService.load(vocabularyListView);

            }
            Console.WriteLine(introduction.SelectedTab.Name);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = int.Parse(listBox1.SelectedIndex.ToString());
            string curItem = (listBox1.Items[index] as NoteModel).Identifier;
            readingWebview.Url = FileOperationService.getHtmlUrlByType(curItem);
            readingWebview.IsWebBrowserContextMenuEnabled = false;
            readingWebview.AllowWebBrowserDrop = false;

        }

        private void readingWebview_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void startTalking_Click(object sender, EventArgs e)
        {
            
            PlayWordSettings playWordSettings = new PlayWordSettings();
            playWordSettings.Form = this;
            playWordSettings.BackgroundToUITask = true;
            playWordSettings.EnglishWordLabel = englishWord;
            playWordSettings.BanglaWordLabel = banglaMeaning;
            playWordSettings.ListView = vocabularyListView;
            playWordSettings.StartIndex = VocabularyService.lastReadIndex;
            if (isStartTalking)
            {
                isStartTalking = false;
                startTalking.Text = "Start Talking";
                playWordSettings.WillRun = false;
                comboBox1.Enabled = true;
            }
            else
            {
                isStartTalking = true;
                startTalking.Text = "Stop Talking";
                comboBox1.Enabled = false;
                playWordSettings.WillRun = true;
            }
            vocabularyService.PlayWords(VocabularyService.words, playWordSettings);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void searchVocabulary_TextChanged(object sender, EventArgs e)
        {
            ListViewItem searchItem = vocabularyListView.FindItemWithText(searchVocabulary.Text, true, 0, true);
           if(searchItem != null)
            {
                vocabularyListView.TopItem = searchItem;
            }
        }

        private void vocabularyListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void vocabularyListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            PlayWordSettings playWordSettings = new PlayWordSettings();
            playWordSettings.EnglishWordLabel = englishWord;
            playWordSettings.BanglaWordLabel = banglaMeaning;
            tempWordModel = VocabularyService.words[e.ItemIndex];
            vocabularyService.UpdateUI(tempWordModel, playWordSettings);
        }

        private void vocabularyListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tempWordModel != null)
                {
                    vocabularyService.SpeakWord(tempWordModel.EnglishWord);
                }
                
            }
        }

        private void vocabularyListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tempWordModel != null)
            {
                vocabularyService.SpeakWord(tempWordModel.EnglishWord);
            }
        }
    }
}
