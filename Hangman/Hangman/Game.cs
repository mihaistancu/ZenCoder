using System.Collections.Generic;

namespace Hangman
{
    public class Game
    {
        private readonly string word;

        public Game(string word)
        {
            this.word = word;
        }

        readonly List<char> goodGuesses = new List<char>();
        readonly List<char> badGuesses = new List<char>();

        public void Guess(char letter)
        {
            if (word.IndexOf(letter) >= 0)
            {
                goodGuesses.Add(letter);
            }
            else
            {
                badGuesses.Add(letter);    
            }
        }

        public char[] GetGoodGuesses()
        {
            return goodGuesses.ToArray();
        }

        public char[] GetBadGuesses()
        {
            return badGuesses.ToArray();
        }
    }
}