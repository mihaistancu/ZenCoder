using System.Collections.Generic;

namespace Hangman
{
    public class Game
    {
        public Game(string word)
        {
            
        }

        readonly List<char> goodGuesses = new List<char>();
 
        public void Guess(char letter)
        {
           goodGuesses.Add(letter); 
        }

        public char[] GetGoodGuesses()
        {
            return goodGuesses.ToArray();
        }
    }
}