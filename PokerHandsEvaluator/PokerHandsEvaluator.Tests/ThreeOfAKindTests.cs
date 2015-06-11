using NUnit.Framework;

namespace PokerHandsEvaluator
{
    public class ThreeOfAKindTests: BaseTests
    {
        [TestCase("As Ac As Qd 8h", "Qc Kh Kc Kh 8d")]
        public void HighestThreeOfAKindWins(string firstHand, string secondHand)
        {
            AssertFirstHandWins(firstHand, secondHand);
        }

        [TestCase("6s 6c 6s Qd 8h", "Ac Ah Kc Kh 8d")]
        public void ThreeOfAKindBeatsTwoPairs(string firstHand, string secondHand)
        {
            AssertFirstHandWins(firstHand, secondHand);
        }
    }
}
