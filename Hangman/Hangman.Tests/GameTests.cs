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
    }
}