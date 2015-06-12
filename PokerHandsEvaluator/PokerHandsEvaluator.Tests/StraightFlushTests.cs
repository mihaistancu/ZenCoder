﻿using NUnit.Framework;

namespace Poker
{
    public class StraightFlushTests: BaseTests
    {
        [TestCase("7s 9s 8s 5s 6s", "3d 4d 2d 6d 5d")]
        public void HighestStraightFlushWins(string firstHand, string secondHand)
        {
            AssertFirstHandWins(firstHand, secondHand);
        }

        [TestCase("4c 3c 5c 2c 6c", "Ac Ah Ac Kh Ad")]
        public void StraightFlushBeatsFourOfAKind(string firstHand, string secondHand)
        {
            AssertFirstHandWins(firstHand, secondHand);
        }
    }
}
