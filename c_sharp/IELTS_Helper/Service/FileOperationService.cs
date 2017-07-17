using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IELTS_Helper.Service
{
    public class FileOperationService
    {

        public static string getFileContent(String location)
        {
            return File.ReadAllText(location);
        }

        public static Uri getReadingQuestionURL(string fileName)
        {
            string fileLocation = Directory.GetCurrentDirectory() + @"\Resources\Reading\HTML\" + fileName + ".html";
            return new Uri(@"file://" + fileLocation);
        }

        public static string GetReqdingQuestionURL(string fileName)
        {
            return @"\Resources\Reading\HTML\" + fileName + "_question.html";
        }
    }
}
