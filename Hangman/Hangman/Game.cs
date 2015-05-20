using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    public class Game
    {
        private readonly string word;

        public Game(string word)
        {
            this.word = word;
        }

        readonly List<char> guessedLetters = new List<char>();

        public void Guess(char letter)
        {
            guessedLetters.Add(letter);
        }

        public IEnumerable<char> GetGoodGuesses()
        {
            return guessedLetters.Where(WordContainsLetter);
        }

        private bool WordContainsLetter(char letter)
        {
            return word.IndexOf(letter) >= 0;
        }

        public IEnumerable<char> GetBadGuesses()
        {
            return guessedLetters.Except(GetGoodGuesses());
        }
    }
}