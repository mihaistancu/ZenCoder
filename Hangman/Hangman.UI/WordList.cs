using System;
using System.IO;

namespace Hangman.UI
{
    class WordList
    {
        private readonly string[] words;
        private readonly Random random;

        public WordList()
        {
            words = File.ReadAllLines("words.txt");
            random = GetRandomNumberGenerator();
        }

        private Random GetRandomNumberGenerator()
        {
            int seed = Guid.NewGuid().GetHashCode();
            return new Random(seed);
        }

        public string GetRandomWord()
        {
            int index = random.Next(words.Length);
            return words[index];
        }
    }
}