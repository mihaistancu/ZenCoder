﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    public class Game
    {
        private readonly string word;

        public Game(string word)
        {
            this.word = word.ToUpper();
            Guess(word[0]);
            Guess(word[word.Length - 1]);
        }

        readonly List<char> guessedLetters = new List<char>();

        public void Guess(char letter)
        {
            letter = char.ToUpper(letter);

            if (!guessedLetters.Contains(letter))
            {
                guessedLetters.Add(letter);
            }
        }

        public Dictionary<int, char> GetHits()
        {
            var hits = new Dictionary<int, char>();

            for (int i = 0; i < word.Length; i++)
            {
                if (guessedLetters.Contains(word[i]))
                {
                    hits[i] = word[i];
                }
            }
            return hits;
        }

        public IEnumerable<char> GetMisses()
        {
            return guessedLetters.Except(GetHits().Values);
        }

        public bool IsWordGuessed()
        {
            return String.Concat(GetHits().Values) == word;
        }

        public string GetWord()
        {
            return word;
        }
    }
}