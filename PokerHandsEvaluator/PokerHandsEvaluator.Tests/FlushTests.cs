using NUnit.Framework;

namespace Poker
{
    public class FlushTests: BaseTests
    {
        [TestCase("5s 2s 9s 4s Js", "3c 6h 8c 9h 4d")]
        public void HighestFlushWins(string firstHand, string secondHand)
        {
            AssertFirstHandWins(firstHand, secondHand);
        }

        [TestCase("4d 3d 5d 2d 6d", "9c Jh Qc Th Kd")]
        public void FlushBeatsStraight(string firstHand, string secondHand)
        {
            AssertFirstHandWins(firstHand, secondHand);
        }
    }
}
