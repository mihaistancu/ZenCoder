using NUnit.Framework;

namespace PokerHandsEvaluator
{
    public class HighCardTests: BaseTests
    {
        [TestCase("Ah 3c 5s 6d 8h", "3s 5h 6c 8d Kh")]
        [TestCase("3c Kh 5s 6d 8h", "3s 5h 6c Qh 8d")]
        [TestCase("3c 5s Qh 6d 8h", "3s Jh 5h 6c 8d")]
        [TestCase("3c 5s 6d Jh 8h", "3s 5h 0h 6c 8d")]
        [TestCase("3c 5s 6d 8h 0h", "9h 3s 5h 6c 8d")]
        [TestCase("9h 3c 5s 6d 8h", "3s 5h 8h 6c 4d")]
        [TestCase("3c 8h 5s 6d 4h", "3s 5h 7h 6c 2d")]
        [TestCase("Ah 3c 5s 6d Kh", "As 5h 6c 8d 4h")]
        public void HighestRankWins(string firstHand, string secondHand)
        {
            AssertFirstHandWins(firstHand, secondHand);
        }
    }
}
