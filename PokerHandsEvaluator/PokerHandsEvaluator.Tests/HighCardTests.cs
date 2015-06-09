using NUnit.Framework;

namespace PokerHandsEvaluator
{
    public class HighCardTests: BaseTests
    {
        [TestCase("Ah 3c 5s 6d 8h", "Kh 3s 5h 6c 8d")]
        [TestCase("Kh 3c 5s 6d 8h", "Qh 3s 5h 6c 8d")]
        [TestCase("Qh 3c 5s 6d 8h", "Jh 3s 5h 6c 8d")]
        [TestCase("Jh 3c 5s 6d 8h", "0h 3s 5h 6c 8d")]
        [TestCase("0h 3c 5s 6d 8h", "9h 3s 5h 6c 8d")]
        [TestCase("9h 3c 5s 6d 8h", "8h 3s 5h 6c 4d")]
        [TestCase("8h 3c 5s 6d 4h", "7h 3s 5h 6c 2d")]
        public void HighestRankWins(string firstHand, string secondHand)
        {
            Setup(firstHand, secondHand);
            AssertFirstHandWins();
        }
    }
}
