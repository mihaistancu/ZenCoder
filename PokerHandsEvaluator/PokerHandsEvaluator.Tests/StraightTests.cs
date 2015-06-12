using NUnit.Framework;

namespace Poker
{
    public class StraightTests: BaseTests
    {
        [TestCase("7s 9c 8s 5d 6h", "3c 4h 2c 6h 5d")]
        public void HighestStraightWins(string firstHand, string secondHand)
        {
            AssertFirstHandWins(firstHand, secondHand);
        }

        [TestCase("4s 3c 5s 2d 6h", "Ac Ah Ac Kh 8d")]
        public void StraightBeatsThreeOfAKind(string firstHand, string secondHand)
        {
            AssertFirstHandWins(firstHand, secondHand);
        }
    }
}
