using NUnit.Framework;

namespace Poker
{
    public class FourOfAKindTests: BaseTests
    {
        [TestCase("As Ac As Qd Ah", "Kc Kh Qc Kh Kd")]
        public void HighestFourOfAKindWins(string firstHand, string secondHand)
        {
            AssertFirstHandWins(firstHand, secondHand);
        }

        [TestCase("6s 3c 6s 6d 6h", "Ac Ah Kc Kh Ad")]
        public void FourOfAKindBeatsFullHouse(string firstHand, string secondHand)
        {
            AssertFirstHandWins(firstHand, secondHand);
        }
    }
}
