using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheWord.Code
{
    internal class Word
    {
        public string Name { get; set; }
        private string[] synonyms = new string[3];


        public Word(string Name, string[] synonyms)
        {
            this.Name = Name;
            this.synonyms = synonyms;
        }

        public string Synonyms()
        {
            return string.Join(", ", synonyms);
        }
    }
}
