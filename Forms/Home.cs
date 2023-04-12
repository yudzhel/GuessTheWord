using GuessTheWord.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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

        private void button1_Click(object sender, EventArgs e)
        {
            UserDialog usr = new UserDialog();
            usr.ShowDialog();
            
        }

        private void buttonLeaderboard_Click(object sender, EventArgs e)
        {
            leaderboard = new Leaderboard();
            leaderboard.Show();
            this.Hide(); 
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
