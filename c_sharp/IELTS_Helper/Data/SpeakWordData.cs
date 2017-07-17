using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IELTS_Helper.Data
{
    public class SpeakWordData
    {
        public Button ButtonInstance { get; set; } = null;
        public string stopText { get; set; }
        public string startText { get; set; }
        public string words { get; set; }
        public bool isStarted { get; set; } = false;
    }
}
