using System;
using System.Windows.Forms;
using System.IO;

namespace Dictionary
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InitialWindow());
        }

        public static StreamReader GetFileStream()
        {
            string directory = "";

            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.RestoreDirectory = true;
                openFile.DefaultExt = "txt";
                openFile.Filter = "txt files (*.txt) | *.txt";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    directory = openFile.FileName;
                }
            }

            StreamReader fileStream = new StreamReader(directory, System.Text.Encoding.Default);

            return fileStream;
        }
    }
}