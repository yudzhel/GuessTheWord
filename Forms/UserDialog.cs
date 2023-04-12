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
    public partial class UserDialog : Form
    {
        public static string PlayerName = "";
        Play playForm;
        public UserDialog()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxPlayerName.Text.Trim()))
            {
                MessageBox.Show("Please enter a player name!");
            }
            else
            {
                PlayerName = textBoxPlayerName.Text.Trim().ToUpper();
               
                playForm = new Play();
                playForm.Show();
                this.Close();
                Program.home.Hide();
            }
        }
    }
}
