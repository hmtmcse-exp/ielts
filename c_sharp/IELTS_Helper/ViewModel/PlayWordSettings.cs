using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IELTS_Helper.ViewModel
{
    public class PlayWordSettings
    {
        public int SpeechDelay { get; set; } = 1;
        public int StartIndex { get; set; } = 0;
        public bool WillRun { get; set; } = true;
        public ListView ListView { get; set; } = null;
        public TextBox EnglishWordLabel { get; set; } = null;
        public TextBox BanglaWordLabel { get; set; } = null;
        public Label SynonymLabel { get; set; } = null;
        public Form Form { get; set; } = null;
        public bool BackgroundToUITask { get; set; } = false;
        public int ExtraInt1 { get; set; } = -1;
    }
}
