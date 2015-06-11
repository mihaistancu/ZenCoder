﻿using System.Linq;

namespace Poker.Hands
{
    class HighCard: Hand
    {
        public override int Compare(Card[] firstHand, Card[] secondHand)
        {
            return Compare(
                GetRanks(firstHand),
                GetRanks(secondHand));
        }

        protected Rank[] GetRanks(Card[] hand)
        {
            return hand.Select(card => card.Rank).ToArray();
        }
    }
}