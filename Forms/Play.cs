using GuessTheWord.Code;
using GuessTheWord.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheWord
{
    public partial class Play : Form
    {
        int timeLeft;
        static WordController wc = new WordController();
        static string wordName = "";
        public static int score = 0;
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
            score = 0;
            labelScore.Text = Convert.ToString(score);
            timeLeft = 30;
            labelTimer.Text = Convert.ToString(timeLeft);
            timer1.Start();
            GenerateWordToGuess();
        }

        private void ButtonGiveUp_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            GameOverDialog gameOverDialog = new GameOverDialog();
            gameOverDialog.ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                labelTimer.Text = Convert.ToString(timeLeft);
            }
            else
            {
                timer1.Stop();
                string path = "D:\\git\\GuessTheWord\\File\\leaderboard.txt";
                File.AppendAllText(path, UserDialog.PlayerName + ":" + score + Environment.NewLine);
                GameOverDialog gameOverDialog = new GameOverDialog();
                gameOverDialog.ShowDialog();
               
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
            labelSynonyms.Text = "SYNONYMS: " + synonyms;
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
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

        private void TextBoxAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) CheckAnswer();
        }

        private void PictureBoxNewWord_Click(object sender, EventArgs e)
        {
            pictureBoxShowHint.Enabled = true;
            hintCount = 3;
            textBoxAnswer.Text = "";
            GenerateWordToGuess();
        }

        private void PictureBoxShowHint_Click(object sender, EventArgs e)
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

        private void PictureBoxNewWord_MouseHover(object sender, EventArgs e)
        {
            toolTipNewWord.SetToolTip(pictureBoxNewWord, "New Word");
        }

        private void PictureBoxShowHint_MouseHover(object sender, EventArgs e)
        {
            toolTipHint.SetToolTip(pictureBoxShowHint, "Hint");
        }
    }
}
