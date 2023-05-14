using GuessTheWord.Forms;
using System;
using System.Windows.Forms;

namespace GuessTheWord
{
    public partial class Home : Form
    {
        Leaderboard leaderboard;

        public Home()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UserDialog usr = new UserDialog();
            usr.ShowDialog();
            
        }

        private void ButtonLeaderboard_Click(object sender, EventArgs e)
        {
            leaderboard = new Leaderboard();
            leaderboard.Show();
            this.Hide(); 
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
