using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class PreparatoryWindow : Form
    {
        private List<Word> Words { get; set; }

        public PreparatoryWindow()
        {
            InitializeComponent();

            Words = Word.CreateDictionary(Program.GetFileStream());
            quantityWords.Text = Words.Count.ToString();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            EssentialWindows essenWin = new EssentialWindows(Words, modeTest.SelectedIndex);
            essenWin.Show();

            Close();
        }

        private void modeTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            startButton.Enabled = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
