using NUnit.Framework;

namespace Poker
{
    public class OnePairTests: BaseTests
    {
        [TestCase("As Ac 5s 6d 8h", "Kc Kh 5c 6h 8d")]
        public void HighestPairWins(string firstHand, string secondHand)
        {
            AssertFirstHandWins(firstHand, secondHand);
        }

        [TestCase("2s 2c 5s 6d 8h", "Ac Kh 5c 6h 8d")]
        public void PairsBeatHighCards(string firstHand, string secondHand)
        {
            AssertFirstHandWins(firstHand, secondHand);
        }
    }
}
