using System.Collections.Generic;
using NUnit.Framework;

namespace Hangman.Tests
{
    [TestFixture]
    public class GameTests
    {
        private Game game;

        [SetUp]
        public void Setup()
        {
            game = new Game("word");    
        }

        [Test]
        public void GameCanProvideCorrectlyGuessedLetters()
        {
            game.Guess('r');
            game.Guess('a');
            var correctLetters = game.GetHits();
            CollectionAssert.AreEquivalent(new Dictionary<int, char> {{0, 'w'}, {2, 'r'}, {3, 'd'}}, correctLetters);
        }

        [Test]
        public void GameCanProvideWronglyGuessedLetters()
        {
            game.Guess('a');
            game.Guess('b');
            var wrongLetters = game.GetMisses();
            CollectionAssert.AreEqual(new []{'a','b'}, wrongLetters);
        }

        [Test]
        public void GameInitiallyRevealsFirstAndLastLetter()
        {
            AssertHitsAre(new Dictionary<int, char> {{0, 'w'}, {3, 'd'}});
        }

        [Test]
        public void GameInitiallyRevealsAllLettersThatAreIdenticalToTheFirstLetter()
        {
            game = new Game("excellent");
            AssertHitsAre(new Dictionary<int, char> {{0, 'e'}, {3, 'e'}, {6, 'e'}, {8, 't'}});
        }

        [Test]
        public void GameInitiallyRevealsAllLettersThatAreIdenticalToTheLastLetter()
        {
            game = new Game("determine");
            AssertHitsAre(new Dictionary<int, char> {{0, 'd'}, {1, 'e'}, {3, 'e'}, {8, 'e'}});
        }

        [Test]
        public void GameRevealsAllLettersThatAreIdenticalToACorrectlyGuessedLetter()
        {
            game = new Game("cerebellum");
            game.Guess('e');
            AssertHitsAre(new Dictionary<int, char> {{0, 'c'}, {1, 'e'}, {3, 'e'}, {5, 'e'}, {9, 'm'}});
        }

        private void AssertHitsAre(Dictionary<int, char> hits)
        {
            CollectionAssert.AreEquivalent(hits, game.GetHits());
        }
    }
}