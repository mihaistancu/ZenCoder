using NUnit.Framework;

namespace PokerHandsEvaluator
{
    public class StraightTests: BaseTests
    {
        [TestCase("As Ac As Qd 8h", "Qc Kh Kc Kh 8d")]
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
