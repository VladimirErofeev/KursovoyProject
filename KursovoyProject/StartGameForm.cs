using System;
using System.Windows.Forms;

namespace KursovoyProject
{
    public partial class StartGameForm : Form
    {
        public StartGameForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Открыть основную форму с игрой
            Form1 gameForm = new Form1();
            gameForm.Show();
            this.Hide(); // Скрыть форму начала игры
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Закрыть приложение
        }
    }
}