using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheWord.Forms
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.home.Show();
        }

        private void PopulateLeaderboard()
        {
            try
            {
                Dictionary<string, int> dictionary = new Dictionary<string, int>();
                var lines = File.ReadLines("D:\\git\\GuessTheWord\\File\\leaderboard.txt");
                int position = 1;
                StringBuilder str = new StringBuilder();

                foreach(var line in lines)
                {
                    string[] lineSplit = line.Split(':');
                    int points = Convert.ToInt32(lineSplit[1]);
                    string player = lineSplit[0];

                    if (dictionary.ContainsKey(player) && points > dictionary[player])
                    {
                        dictionary[player] = points;
                    } 
                    else if (dictionary.ContainsKey(player) && points <= dictionary[player]) continue;
                    else
                    {
                        dictionary.Add(player, points);
                    }
                    
                }

                foreach(var entry in dictionary.OrderByDescending(key => key.Value))
                {
                    if (position > 15) break;
                    str.Append($"{position}.\t{entry.Key} - {entry.Value} \n");
                    position++;
                }

                labelLeaderboard.Text = str.ToString();
                

            }
            catch(Exception ex)
            {
                labelLeaderboard.Text = ex.Message;
            }
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            PopulateLeaderboard();
        }
    }
}
