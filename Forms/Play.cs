using GuessTheWord.Code;
using GuessTheWord.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GuessTheWord
{
    public partial class Play : Form
    {
        int timeLeft;
        static WordController wc = new WordController();
        static string wordName = "";
        static int score = 0;
        static string synonyms = "";
        static char firstLetter;
        static int hintCount = 3;
        public Play()
        {
            InitializeComponent();
        }

        private void Play_Load(object sender, EventArgs e)
        {
            labelPlayerName.Text = UserDialog.PlayerName;
            labelScore.Text = Convert.ToString(score);
            timeLeft = 20;
            labelTimer.Text = Convert.ToString(timeLeft);
            timer1.Start();
            GenerateWordToGuess();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.home.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                labelTimer.Text = Convert.ToString(timeLeft);
            }
            else
            {
                timer1.Stop();
                string gameOverText = "You scored: " + score;
                
                MessageBox.Show(gameOverText, "Time's Up!");
            }
               
        }

        private void GenerateWordToGuess()
        {
            Word generatedWord = wc.GenerateWord();
            wordName = generatedWord.Name.ToUpper();
            int wordLength = wordName.Length;
            firstLetter = wordName[0];

            char[] wordHidden = new char[wordLength];
            wordHidden[0] = firstLetter;

            synonyms = generatedWord.Synonyms();

            for (int i = 1; i < wordLength; i++)
            {
                wordHidden[i] = '_';
            }

            labelWordToGuess.Text = string.Join(" ", wordHidden);
            labelSynonyms.Text = synonyms;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }

        private void CheckAnswer()
        {
            if (textBoxAnswer.Text.Trim().Equals(wordName))
            {
                CorrectAnswer();
                score += hintCount;
                labelScore.Text = Convert.ToString(score);
                hintCount = 3;
                pictureBoxShowHint.Enabled = true;

            }
            else
            {
                WrongAnswer();
            }
        }

        private async void WrongAnswer()
        {
            textBoxAnswer.BackColor = Color.Red;
            await Task.Delay(100);
            textBoxAnswer.BackColor = Color.White;
        }

        private async void CorrectAnswer()
        {
            textBoxAnswer.BackColor = Color.LightGreen;
            await Task.Delay(100);
            textBoxAnswer.BackColor = Color.White;
            textBoxAnswer.Text = "";
            GenerateWordToGuess();
        }

        private void textBoxAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) CheckAnswer();
        }

        private void pictureBoxNewWord_Click(object sender, EventArgs e)
        {
            pictureBoxShowHint.Enabled = true;
            hintCount = 3;
            textBoxAnswer.Text = "";
            GenerateWordToGuess();
        }

        private void pictureBoxShowHint_Click(object sender, EventArgs e)
        {
            char[] wordHidden = new char[wordName.Length];
            for (int i = 0; i < wordHidden.Length; i++)
            {
                wordHidden[i] = '_';
            }
            wordHidden[0] = firstLetter;

            if (hintCount == 3)
            {
                wordHidden[wordHidden.Length - 1] = Char.ToUpper(wordName[wordName.Length - 1]);
                labelWordToGuess.Text = string.Join(" ", wordHidden);
                hintCount--;
            }

            else if (hintCount == 2)
            {
                wordHidden[wordHidden.Length - 1] = Char.ToUpper(wordName[wordName.Length - 1]);
                wordHidden[wordHidden.Length / 2] = Char.ToUpper(wordName[wordName.Length / 2]);
                labelWordToGuess.Text = string.Join(" ", wordHidden);
                pictureBoxShowHint.Enabled = false;
                hintCount--;
            }
        }
    }
}
