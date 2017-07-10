using IELTS_Helper.Database;
using IELTS_Helper.Service;
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
            if (introduction.SelectedTab.Name == "reading")
            {

                NoteService noteService = new NoteService();
                listBox1.DataSource = noteService.GetNotesByGroupName(AppConstant.READING);
                listBox1.DisplayMember = "DisplayName";
                listBox1.ValueMember = "Id";
                readingWebview.Url = new Uri(@"file://" + System.IO.Directory.GetCurrentDirectory() + @"\Resources\Reading\HTML\1_visual_symbols_and_the_blind.html");

            }

            Console.WriteLine(introduction.SelectedTab.Name);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void readingWebview_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
