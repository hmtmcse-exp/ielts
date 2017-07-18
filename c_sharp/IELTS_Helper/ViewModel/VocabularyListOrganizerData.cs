using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IELTS_Helper.ViewModel
{
    public class VocabularyListOrganizerData
    {
        public List<WordModel> WordModelList { get; set; } = null;
        public List<ListViewItem> ListViewItemList { get; set; } = null;
        public TextBox EnglishWordText { get; set; } = null;
        public TextBox BanglaWordText { get; set; } = null;
        public TextBox SynonymsText { get; set; } = null;
        public TextBox SearchBoxText { get; set; } = null;
        public Button PlayAllButton { get; set; } = null;
        public Button ReloadButton { get; set; } = null;
        public ListView ListViewInstance { get; set; } = null;
        public int PlayWordLastIndex { get; set; } = 0;
        public int PlayWordLoopDelay { get; set; } = 1;
        public string[] Header {get;set;}
        public Form Form { get; set; } = null;
        public string PlayButtonStartText { get; set; } = "Play All";
        public string PlayButtonStoptText { get; set; } = "Stop Play";

    }
}
