using NUnit.Framework;

namespace Poker
{
    public class FullHouseTests: BaseTests
    {
        [TestCase("Ac As Jd Jh Jh", "Kh Ks Qh Qc Qd")]
        public void HighestFullHouseWins(string firstHand, string secondHand)
        {
            AssertFirstHandWins(firstHand, secondHand);
        }

        [TestCase("5c 2s 5d 5h 2h", "9c Jh Qc Th Kd")]
        public void FullHouseBeatsFlush(string firstHand, string secondHand)
        {
            AssertFirstHandWins(firstHand, secondHand);
        }
    }
}
