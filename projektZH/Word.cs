using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektZH
{
    internal class Word
    {
        public string wordToGuess { get; private set; }

        public string WordMask { get; private set; }
        public string WordFound { get; internal set; }

        public Word(string wordToGuess)
        {
            this.wordToGuess = wordToGuess.ToUpper();
            this.WordMask = new string('_', wordToGuess.Length);
        }

        public bool Guess(char letter)
        {
            bool found = false;
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == char.ToUpper(letter))
                {
                    char[] tempWordMask = WordMask.ToCharArray();
                    tempWordMask[i] = letter;
                    WordMask = new string(tempWordMask);
                    found = true;
                }
            }
            return found;
        }
    }
}
