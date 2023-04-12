using GuessTheWord.Code;
using GuessTheWord.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        static int hintCount = 2;
        public Play()
        {
            InitializeComponent();
        }

        private void Play_Load(object sender, EventArgs e)
        {
            labelPlayerName.Text = UserDialog.PlayerName;
            labelScore.Text = Convert.ToString(score);
            timeLeft = 300;
            labelTimer.Text = "300";
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
                timeLeft = timeLeft - 1;
                labelTimer.Text = Convert.ToString(timeLeft);
        }

        private void GenerateWordToGuess()
        {
            Word generatedWord = wc.GenerateWord();
            wordName = generatedWord.Name;
            int wordLength = wordName.Length;
            firstLetter = wordName[0];
            char firstHint = wordName[wordLength - 1];
            char secondHint = wordName[wordLength - 3];

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

        private void buttonNewWord_Click(object sender, EventArgs e)
        {
            buttonShowHint.Enabled = true;
            hintCount = 2;
            GenerateWordToGuess();
        }

        private void buttonShowHint_Click(object sender, EventArgs e)
        {
            char[] wordHidden = new char[wordName.Length];
            for (int i = 0; i < wordHidden.Length; i++)
            {
                wordHidden[i] = '_';
            }
            wordHidden[0] = firstLetter;

            if (hintCount == 2)
            {
                wordHidden[wordHidden.Length - 1] = Char.ToUpper(wordName[wordName.Length - 1]);
                labelWordToGuess.Text = string.Join(" ", wordHidden);
                hintCount--;
            }

            else if (hintCount == 1)
            {
                wordHidden[wordHidden.Length - 1] = Char.ToUpper(wordName[wordName.Length - 1]);
                wordHidden[wordHidden.Length / 2] = Char.ToUpper(wordName[wordName.Length / 2]);
                labelWordToGuess.Text = string.Join(" ", wordHidden);
                buttonShowHint.Enabled = false;
            }

        }
    }
}
