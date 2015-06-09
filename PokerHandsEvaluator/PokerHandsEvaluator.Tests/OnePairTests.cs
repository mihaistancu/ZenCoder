using NUnit.Framework;

namespace PokerHandsEvaluator
{
    public class OnePairTests: BaseTests
    {
        [TestCase("As Ac 5s 6d 8h", "Kc Kh 5c 6h 8d")]
        public void HighestPairWins(string firstHand, string secondHand)
        {
            Setup(firstHand, secondHand);
            AssertFirstHandWins();
        }
    }
}
