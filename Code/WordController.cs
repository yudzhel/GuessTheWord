using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheWord.Code
{
    internal class WordController
    {
        private List<Word> wordsList = new List<Word>();

        public WordController()
        {
            PopulateDatabase();
        }
        private void PopulateDatabase()
        {
            wordsList.Add(new Word("Allow", new string[] { "Permit", "Authorize", "Grant" }));
            wordsList.Add(new Word("Amazing", new string[] { "Astonishing", "Incredible", "Unbelievable" }));
            wordsList.Add(new Word("Begin", new string[] { "Start", "Launch", "Initiate" }));
            wordsList.Add(new Word("Describe", new string[] { "Portray", "Characterize", "Picture" }));
            wordsList.Add(new Word("Mischievous", new string[] { "Prankish", "Waggish", "Impish" }));
            wordsList.Add(new Word("Strange", new string[] { "Odd", "Peculiar", "Unusual" }));
            wordsList.Add(new Word("Correct", new string[] { "True", "Right", "Accurate" }));
            wordsList.Add(new Word("Dedicated", new string[] { "Committed", "Devoted", "Loyal" }));
        }

        public Word GenerateWord()
        {
            var random = new Random();
            int index = random.Next(wordsList.Count);
            return wordsList[index];

        }
    }
}
