using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DemoDelegate
{
    delegate string str2str(string str);
    public class NumbersSort
    {
        private List<int> numberReader(string _text)
        {
            var _list = new List<int>();
            var regex = new Regex(@"[\-]{0,1}\d+");
            var matches = regex.Matches(_text);
            foreach (Match match in matches)
            {
                _list.Add(int.Parse(match.ToString()));
            }
            _list.Sort();
            return _list;
        }
        public string Content { get; }
        private string winFormRead(string filePath = "")
        {
            var fileContent = string.Empty;
            filePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                var fileStream = openFileDialog.OpenFile();


                StreamReader reader = new StreamReader(fileStream);
                fileContent = reader.ReadToEnd();
                reader.Close();
            }
            string _tmp = "";
            foreach (var item in numberReader(fileContent))
            {
                _tmp = _tmp + "  " + item;
            }

            return _tmp;
        }
        private string consoleRead(string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += "\\" + fileName;
            var sr = new StreamReader(path);
            string fileContent = sr.ReadToEnd();
            sr.Close();
            string _tmp = "";
            foreach (var item in numberReader(fileContent))
            {
                _tmp = _tmp + "  " + item; 
            }
            
            return _tmp;

        }
        public NumbersSort(string trigger = "")
        {
            str2str read;
            if (trigger == "console")
            {
                read = consoleRead;   
            }
            else
            {
                read = winFormRead;
            }
            Content = read?.Invoke("Numbers.txt");
        }
    }

        
}
