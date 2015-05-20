using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hangman.Tests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void GameCanBeCreated()
        {
            var game = new Game("word");
        }

        [TestMethod]
        public void UserCanGuessALetter()
        {
            var game = new Game("word");
            game.Guess('a');
        }

        [TestMethod]
        public void GameCanProvideCorrectlyGuessedLetters()
        {
            var game = new Game("word");
            game.Guess('w');
            game.Guess('o');
            game.Guess('a');
            var correctLetters = game.GetGoodGuesses();
            CollectionAssert.AreEqual(correctLetters, new []{'w','o'});
        }

        [TestMethod]
        public void GameCanProvideWronglyGuessedLetters()
        {
            var game = new Game("word");
            game.Guess('w');
            game.Guess('a');
            game.Guess('b');
            var wrongLetters = game.GetBadGuesses();
            CollectionAssert.AreEqual(wrongLetters, new []{'a','b'});
        }
    }
}