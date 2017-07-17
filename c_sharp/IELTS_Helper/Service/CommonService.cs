using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IELTS_Helper.Service
{
    public class CommonService
    {

        public static void SetContentToWebbrowser(WebBrowser webBrowser, string location)
        {
            string fileLocation = Directory.GetCurrentDirectory() + location;
            Uri uri = new Uri(@"file://" + fileLocation);
            if (File.Exists(uri.LocalPath))
            {
                webBrowser.Url = uri;
            }
            else
            {
                webBrowser.DocumentText = "<h1>Content Not Available </h1>";
            }           
            webBrowser.IsWebBrowserContextMenuEnabled = false;
            webBrowser.AllowWebBrowserDrop = false;
        }

       
    }
}
