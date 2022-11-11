using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDelegate
{
    internal class NumbersSort
    {
        delegate string str2str(string str);
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
            return fileContent;
        }
        private string consoleRead(string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += "\\" + fileName;
            StreamReader sr = new StreamReader(path);
            string fileContent = sr.ReadToEnd();
            sr.Close();
            return fileContent;
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
