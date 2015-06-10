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
    }
}
