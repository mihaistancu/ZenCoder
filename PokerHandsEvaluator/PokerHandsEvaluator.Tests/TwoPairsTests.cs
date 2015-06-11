using NUnit.Framework;

namespace PokerHandsEvaluator
{
    public class TwoPairsTests: BaseTests
    {
        [TestCase("As Ac Qs Qd 8h", "Qc Qh Kc Kh 8d")]
        public void HighestTwoPairWins(string firstHand, string secondHand)
        {
            AssertFirstHandWins(firstHand, secondHand);
        }

        [TestCase("6s 6c Qs Qd 8h", "2c 3h Kc Kh 8d")]
        public void TwoPairsBeatsOnePair(string firstHand, string secondHand)
        {
            AssertFirstHandWins(firstHand, secondHand);
        }
    }
}
