using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheWord.Forms
{
    public partial class GameOverDialog : Form
    {
        public GameOverDialog()
        {
            InitializeComponent();
        }

        private void GameOverDialog_Load(object sender, EventArgs e)
        {
            labelPoints.Text = Convert.ToString(Play.score) + " points";
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            Program.play.Close();
            Close();
            Play newGame = new Play();
            Program.play = newGame;
            newGame.Show();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Program.play.Close();
            Close();
            Program.home.Show();
        }
    }
}
