using IELTS_Helper.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IELTS_Helper.Service
{
    public class VocabularyListService
    {
        private VocabularyListOrganizerData vlod = null;

        public void Populate(VocabularyListOrganizerData vlod)
        {
            this.vlod = vlod;

            if (vlod != null)
            {
                if (vlod.ListViewInstance != null && vlod.ListViewItemList != null && vlod.Header.Length != 0)
                {
                    vlod.ListViewInstance.Clear();
                    vlod.ListViewInstance.View = View.Details;
                    vlod.ListViewInstance.GridLines = true;
                    vlod.ListViewInstance.FullRowSelect = true;
                    for (int a = 0; a < vlod.Header.Length; a++)
                    {
                        vlod.ListViewInstance.Columns.Add(vlod.Header[a]);
                    }

                    foreach (ListViewItem listViewItem in vlod.ListViewItemList)
                    {
                        vlod.ListViewInstance.Items.Add(listViewItem);
                    }

                    vlod.ListViewInstance.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    vlod.ListViewInstance.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                    if (vlod.SearchBoxText != null)
                    {
                       vlod.SearchBoxText.TextChanged += this.SearchTextBoxChanged;
                    }

                    vlod.ListViewInstance.ItemSelectionChanged += this.ListViewItemSelectionChanged;
                }
            }

        }


        private void SearchTextBoxChanged(object sender, EventArgs e)
        {
            ListViewItem searchItem = vlod.ListViewInstance.FindItemWithText(vlod.SearchBoxText.Text, true, 0, true);
            if (searchItem != null)
            {
                vlod.ListViewInstance.TopItem = searchItem;
            }
        }

        private void ListViewItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(vlod.WordModelList != null)
            {
                this.UpdateUI(vlod.WordModelList[e.ItemIndex]);
            }
            
        }

        private void UpdateUI(WordModel wordModel)
        {
            if(wordModel == null)
            {
                return;
            }

            if (vlod.BanglaWordText != null)
            {
                vlod.BanglaWordText.Text = wordModel.BanglaMeaning;
            }

            if (vlod.EnglishWordText != null)
            {
                vlod.EnglishWordText.Text = wordModel.EnglishWord;
            }

            if (vlod.SynonymsText != null)
            {
                vlod.SynonymsText.Text = wordModel.Synonym;
            }
        }

    }
}
