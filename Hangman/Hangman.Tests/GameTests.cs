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
            CollectionAssert.AreEquivalent(new Dictionary<int, char> {{0, 'W'}, {2, 'R'}, {3, 'D'}}, correctLetters);
        }

        [Test]
        public void GameCanProvideWronglyGuessedLetters()
        {
            game.Guess('a');
            game.Guess('b');
            var wrongLetters = game.GetMisses();
            CollectionAssert.AreEqual(new []{'A','B'}, wrongLetters);
        }

        [Test]
        public void GameInitiallyRevealsFirstAndLastLetter()
        {
            AssertHitsAre(new Dictionary<int, char> {{0, 'W'}, {3, 'D'}});
        }

        [Test]
        public void GameInitiallyRevealsAllLettersThatAreIdenticalToTheFirstLetter()
        {
            game = new Game("excellent");
            AssertHitsAre(new Dictionary<int, char> {{0, 'E'}, {3, 'E'}, {6, 'E'}, {8, 'T'}});
        }

        [Test]
        public void GameInitiallyRevealsAllLettersThatAreIdenticalToTheLastLetter()
        {
            game = new Game("determine");
            AssertHitsAre(new Dictionary<int, char> {{0, 'D'}, {1, 'E'}, {3, 'E'}, {8, 'E'}});
        }

        [Test]
        public void GameRevealsAllLettersThatAreIdenticalToACorrectlyGuessedLetter()
        {
            game = new Game("cerebellum");
            game.Guess('e');
            AssertHitsAre(new Dictionary<int, char> {{0, 'C'}, {1, 'E'}, {3, 'E'}, {5, 'E'}, {9, 'M'}});
        }

        private void AssertHitsAre(Dictionary<int, char> expectedHits)
        {
            CollectionAssert.AreEquivalent(expectedHits, game.GetHits());
        }

        [Test]
        public void GameCanTellWhenWordIsGuessed()
        {
            game.Guess('o');
            game.Guess('r');
            Assert.IsTrue(game.IsWordGuessed());
        }

        [Test]
        public void GuessesAreCaseInsensitive()
        {
            game.Guess('O');
            AssertHitsAre(new Dictionary<int, char> { { 0, 'W' }, { 1, 'O' }, { 3, 'D' } });
        }

        [Test]
        public void GameCanReturnTheActualWord()
        {
            Assert.AreEqual("WORD", game.GetWord());
        }
    }
}