using System.Collections.Generic;
using NUnit.Framework;

namespace Hangman.Tests
{
    [TestFixture]
    public class GameTests
    {
        private Game game;

        [TestFixtureSetUp]
        public void Setup()
        {
            game = new Game("word");    
        }

        [Test]
        public void GameCanProvideCorrectlyGuessedLetters()
        {
            game.Guess('w');
            game.Guess('r');
            game.Guess('a');
            var correctLetters = game.GetHits();
            CollectionAssert.AreEquivalent(new Dictionary<int, char> { { 0, 'w' }, { 2, 'r' } }, correctLetters);
        }

        [Test]
        public void GameCanProvideWronglyGuessedLetters()
        {
            game.Guess('w');
            game.Guess('a');
            game.Guess('b');
            var wrongLetters = game.GetMisses();
            CollectionAssert.AreEqual(new []{'a','b'}, wrongLetters);
        }
    }
}