using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hangman.Tests
{
    [TestClass]
    public class GameTests
    {
        private Game game;

        [TestInitialize]
        public void Setup()
        {
            game = new Game("word");    
        }

        [TestMethod]
        public void GameCanProvideCorrectlyGuessedLetters()
        {
            game.Guess('w');
            game.Guess('o');
            game.Guess('a');
            var correctLetters = game.GetGoodGuesses().ToArray();
            CollectionAssert.AreEqual(correctLetters, new []{'w','o'});
        }

        [TestMethod]
        public void GameCanProvideWronglyGuessedLetters()
        {
            game.Guess('w');
            game.Guess('a');
            game.Guess('b');
            var wrongLetters = game.GetBadGuesses().ToArray();
            CollectionAssert.AreEqual(wrongLetters, new []{'a','b'});
        }
    }
}