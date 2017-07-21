using IELTS_Helper.Service;
using IELTS_Helper.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IELTS_Helper.AppForms
{
    public partial class VocabularyAddUpdate : Form
    {
        private WordModel wordModel = null;
        private string noteId = null;

        public VocabularyAddUpdate()
        {
            InitializeComponent();
            wordModel = VocabularyListService.NextFormWordModel;
            noteId = VocabularyListService.NoteId;
            OnLoadForm();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void OnLoadForm()
        {
            if(wordModel != null)
            {
                EnglishWordTB.Text = wordModel.EnglishWord;
                BanglaMeaningTB.Text = wordModel.BanglaMeaning;
                PartsOfSpeechTB.Text = wordModel.PartsOfSpeech;
                SynonymTB.Text = wordModel.Synonym;
                EnglishPastTenseTB.Text = wordModel.EnglishPastTense;
                EnglishPastParticipleTB.Text = wordModel.EnglishPastParticiple;
                StatusTB.Text = wordModel.Status;
                EnglishPluralsTB.Text = wordModel.EnglishPlurals;
            }

        }

        private void SaveVocabulary_Click(object sender, EventArgs e)
        {
            string setFields = "";
            setFields += "en ='" + EnglishWordTB.Text + "',";
            setFields += "en_past ='" + EnglishPastTenseTB.Text + "',";
            setFields += "en_past_participle ='" + EnglishPastParticipleTB.Text + "',";
            setFields += "en_plural ='" + EnglishPluralsTB.Text + "',";
            setFields += "bd ='" + BanglaMeaningTB.Text + "',";
            setFields += "en_ps ='" + PartsOfSpeechTB.Text + "',";
            setFields += "en_synonym ='" + SynonymTB.Text + "',";
            setFields += "status ='" + StatusTB.Text + "'";
            VocabularyService.UpdateDatabaseVacabulary(wordModel.Id, setFields);
            MessageBox.Show("Data Saved","Info");
        }

        private void DeleteVocabulary_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item " + EnglishWordTB.Text +" ?? ","Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if(noteId != null)
                {
                    VocabularyService.DeleteWordAndMappingFromDatabaseVacabulary(wordModel.Id, noteId);
                }
                else
                {
                    VocabularyService.DeleteDatabaseVacabulary(wordModel.Id);
                }               
                this.Close();
            }
        }
    }
}
