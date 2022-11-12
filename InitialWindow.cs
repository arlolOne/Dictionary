using System;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class InitialWindow : Form
    {
        public InitialWindow()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            try
            {
                PreparatoryWindow prepWin = new PreparatoryWindow();
                prepWin.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Выбранный файл имеет неверный формат! \n"
                       + "См. подробнее 'Формат файла'.");
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            InfoWindow infoWin = new InfoWindow();
            infoWin.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
