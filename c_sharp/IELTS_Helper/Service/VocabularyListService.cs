using IELTS_Helper.AppForms;
using IELTS_Helper.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IELTS_Helper.Service
{
    public class VocabularyListService
    {
        private VocabularyListOrganizerData vlod = null;
        private WordModel tempWordModel = null;
        public TextToSoundService textToSound = new TextToSoundService();
        private Thread thread = null;
        private bool isPlayLoopOn = false;
        public static WordModel NextFormWordModel = null;

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
                        vlod.SearchBoxText.TextChanged -= this.SearchTextBoxChanged;
                        vlod.SearchBoxText.TextChanged += this.SearchTextBoxChanged;
                    }

                    vlod.ListViewInstance.ItemSelectionChanged -= this.ListViewItemSelectionChanged;
                    vlod.ListViewInstance.ItemSelectionChanged += this.ListViewItemSelectionChanged;

                    vlod.ListViewInstance.MouseDoubleClick -= this.ListViewMouseDoubleClick;
                    vlod.ListViewInstance.MouseDoubleClick += this.ListViewMouseDoubleClick;

                    vlod.ListViewInstance.KeyDown -= this.ListViewKeyDown;
                    vlod.ListViewInstance.KeyDown += this.ListViewKeyDown;

                    if (vlod.PlayAllButton != null && vlod.Form != null)
                    {
                        vlod.PlayAllButton.Text = vlod.PlayButtonStartText;
                        isPlayLoopOn = false;
                        vlod.PlayAllButton.Click -= this.PlayAllButtonClick;
                        vlod.PlayAllButton.Click += this.PlayAllButtonClick;
                    }

                    if(vlod.ReloadButton != null && vlod.ReloadAllData != null)
                    {
                        vlod.ReloadButton.Click -= ReloadButtonClick;
                        vlod.ReloadButton.Click += ReloadButtonClick;
                    }
                }
            }

        }

        private void ReloadButtonClick(object sender, EventArgs e)
        {
            if (vlod.ReloadAllData != null)
            {
                vlod.ReloadAllData.Invoke(vlod);
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
                tempWordModel = vlod.WordModelList[e.ItemIndex];
                this.UpdateUI(tempWordModel);
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


        private void ListViewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tempWordModel != null)
                {
                    textToSound.PlayAsync(tempWordModel.EnglishWord);
                }

            }
        }

        private void ListViewMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tempWordModel != null)
            {
                textToSound.PlayAsync(tempWordModel.EnglishWord);
            }

            if (tempWordModel != null && true)
            {
                NextFormWordModel = tempWordModel;
                VocabularyAddUpdate vocabularyAddUpdate = new VocabularyAddUpdate();
                vocabularyAddUpdate.ShowDialog(vlod.Form);
            }
        }

        private void SelectListViewRow(int rowIndex)
        {
            vlod.ListViewInstance.SelectedItems.Clear();
            vlod.ListViewInstance.Items[rowIndex].Selected = true;
            vlod.ListViewInstance.Items[rowIndex].Focused = true;
            vlod.ListViewInstance.TopItem = vlod.ListViewInstance.Items[rowIndex];
            vlod.ListViewInstance.Select();
        }

        private void PlayWordInBackground()
        {
            for (int i = vlod.PlayWordLastIndex; i < vlod.WordModelList.Count(); i++)
            {
                WordModel wordModel = vlod.WordModelList[i];
                vlod.PlayWordLastIndex = i;
                if (wordModel.EnglishWord != null)
                {
                    if (vlod.Form != null)
                    {
                        vlod.Form.Invoke
                            ((MethodInvoker)delegate
                            {
                                SelectListViewRow(i);
                            }
                            );
                    }
                    textToSound.Play(wordModel.EnglishWord);
                    vlod.PlayWordLastIndex++;
                    Thread.Sleep(1000 * vlod.PlayWordLoopDelay);
                }
                else
                {
                    vlod.PlayWordLastIndex++;
                }

            }
        }

        private void PlayAllButtonClick(object sender, EventArgs e)
        {
            if (thread != null)
            {
                thread.Abort();
            }
            thread = new Thread(() => PlayWordInBackground());
            if (isPlayLoopOn)
            {
                thread.Abort();
                isPlayLoopOn = false;
                vlod.PlayAllButton.Text = vlod.PlayButtonStartText;
            }
            else
            {
                thread.Start();
                isPlayLoopOn = true;
                vlod.PlayAllButton.Text = vlod.PlayButtonStoptText;
            }
        }

    }
}
