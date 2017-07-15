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
        bool isShowQuestionPanel = false;
        bool isShowVocabularyPanel = false;
        String lastReadinVocabularyModelKey = null;

        public IELTS()
        {
            InitializeComponent();
            onLoadForm();
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
            NoteModel noteModel = (listBox1.Items[index] as NoteModel);
            readingWebview.Url = FileOperationService.getHtmlUrlByType(noteModel.Identifier);
            readingWebview.IsWebBrowserContextMenuEnabled = false;
            readingWebview.AllowWebBrowserDrop = false;
            lastReadinVocabularyModelKey = VocabularyService.GetModelKey(noteModel.Id + "", AppConstant.READING);
            vocabularyService.LoadReadingListViewVocabulary(noteModel.Id + "", readingVocabularyListView);

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

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void ReadContents_Click(object sender, EventArgs e)
        {

            //vocabularyService.speechSynthesizer.SpeakAsyncCancelAll();
            //vocabularyService.speechSynthesizer.Rate = -4;
            //vocabularyService.SpeakWord(readingWebview.Document.Body.InnerText);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //readingContentTableLayout.RowStyles[0] = new RowStyle(SizeType.Percent, 25);
            //readingContentTableLayout.ColumnStyles[0] = new ColumnStyle(SizeType.Percent,25);
            //readingContentTableLayout.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 55);
            //readingContentTableLayout.ColumnStyles[2] = new ColumnStyle(SizeType.Percent, 20);
            //  readingContentTableLayout.RowStyles[1] = new RowStyle(SizeType.Percent, 55);
        }

        private void readingContentTableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showHideQuestion_Click(object sender, EventArgs e)
        {
            if (isShowQuestionPanel)
            {
                topicDetailsQuestionPanel.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100);
                topicDetailsQuestionPanel.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 0);
                showHideQuestion.Text = "Show Question";
                isShowQuestionPanel = false;
            }
            else
            {
                topicDetailsQuestionPanel.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 60);
                topicDetailsQuestionPanel.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 40);
                showHideQuestion.Text = "Hide Question";
                isShowQuestionPanel = true;
            }
            
        }

        private void showHideVocTop_Click(object sender, EventArgs e)
        {
            if (isShowVocabularyPanel)
            {
                vocabularyTopicPanel.RowStyles[1] = new RowStyle(SizeType.Percent, 100);
                vocabularyTopicPanel.RowStyles[2] = new RowStyle(SizeType.Percent, 0);
                showHideVocTop.Text = "Show Vocabulary";
                isShowVocabularyPanel = false;
            }
            else
            {
                vocabularyTopicPanel.RowStyles[1] = new RowStyle(SizeType.Percent, 0);
                vocabularyTopicPanel.RowStyles[2] = new RowStyle(SizeType.Percent, 100);
                showHideVocTop.Text = "Show Topics";
                isShowVocabularyPanel = true;
            }
        }

        private void readingVocabularyListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void readingVocabularyListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(lastReadinVocabularyModelKey != null)
            {
                PlayWordSettings playWordSettings = new PlayWordSettings();
                playWordSettings.EnglishWordLabel = readingEnglisWordText;
                playWordSettings.BanglaWordLabel = readingBanglaWordText;
                playWordSettings.SynonymTextBox = readingSynonymText;
                tempWordModel = VocabularyService.wordMap[lastReadinVocabularyModelKey][e.ItemIndex];
                vocabularyService.UpdateUI(tempWordModel, playWordSettings);
            }
        }

        private void onLoadForm()
        {
            vocabularyTopicPanel.RowStyles[2] = new RowStyle(SizeType.Percent, 0);
            vocabularyTopicPanel.RowStyles[1] = new RowStyle(SizeType.Percent, 100);
        }

        private void playAll_Click(object sender, EventArgs e)
        {
            PlayWordSettings playWordSettings = new PlayWordSettings();
            playWordSettings.Form = this;
            playWordSettings.BackgroundToUITask = true;
            playWordSettings.EnglishWordLabel = readingEnglisWordText;
            playWordSettings.BanglaWordLabel = readingBanglaWordText;
            playWordSettings.SynonymTextBox = readingSynonymText;
            playWordSettings.ListView = readingVocabularyListView;
            playWordSettings.StartIndex = 0;
            if (isStartTalking)
            {
                isStartTalking = false;
                playAll.Text = "Play All";
                playWordSettings.WillRun = false;
                comboBox1.Enabled = true;
            }
            else
            {
                isStartTalking = true;
                playAll.Text = "Stop";
                playWordSettings.WillRun = true;
            }
            vocabularyService.PlayWords(VocabularyService.wordMap[lastReadinVocabularyModelKey], playWordSettings);
        }

        private void readingSearch_TextChanged(object sender, EventArgs e)
        {
            ListViewItem searchItem = readingVocabularyListView.FindItemWithText(readingSearch.Text, true, 0, true);
            if (searchItem != null)
            {
                readingVocabularyListView.TopItem = searchItem;
            }
        }

        private void ReadContents_Click_1(object sender, EventArgs e)
        {
            vocabularyService.speechSynthesizer.SpeakAsyncCancelAll();
            vocabularyService.speechSynthesizer.Rate = -4;
            vocabularyService.SpeakWord(readingWebview.Document.Body.InnerText);

        }
    }
}
