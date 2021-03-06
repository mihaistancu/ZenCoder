﻿namespace Poker.Hands
{
    internal class StraightFlush: Straight
    {
        private readonly Flush flush = new Flush();

        internal override bool Matches(Card[] hand)
        {
            return base.Matches(hand) && flush.Matches(hand);
        }
    }
}
