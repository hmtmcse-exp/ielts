using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IELTS_Helper.Service
{
    public class FileOperationService
    {

        public static string getFileContent(String location)
        {
            return File.ReadAllText(location);
        }

        public static Uri getHtmlUrlByType(string type, string fileName)
        {
            return new Uri(@"file://" + System.IO.Directory.GetCurrentDirectory() + @"\Resources\Reading\HTML\" + fileName + ".html");
        }

    }
}
