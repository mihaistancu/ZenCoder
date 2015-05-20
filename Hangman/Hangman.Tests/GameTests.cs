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
            var correctLetters = game.GetGoodGuesses();
            CollectionAssert.AreEqual(correctLetters, new []{'w','o'});
        }


    }
}