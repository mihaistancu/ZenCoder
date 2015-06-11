using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker.Hands
{
    class Straight: HighCard
    {
        public override int Compare(Card[] firstHand, Card[] secondHand)
        {
            if (Matches(firstHand) && Matches(secondHand))
            {
                return base.Compare(firstHand, secondHand);
            }

            return Matches(firstHand).CompareTo(Matches(secondHand));
        }

        private bool Matches(Card[] hand)
        {   
            var ranks = GetRanks(hand);

            return AreEqual(ranks, GetBabyStraight()) 
                || AreEqual(ranks, GetStraightStartingAt(ranks.Min()));
        }

        private bool AreEqual(IEnumerable<Rank> a, IEnumerable<Rank> b)
        {
            return SortDescending(a).SequenceEqual(SortDescending(b));
        }

        private IEnumerable<Rank> GetBabyStraight()
        {
            return new [] {Rank.Ace, Rank.Two, Rank.Three, Rank.Four};
        }

        private IEnumerable<Rank> GetStraightStartingAt(Rank startRank)
        {
            int startIndex = Array.IndexOf(GetRanks(), startRank);
            return GetRanks().Skip(startIndex).Take(5);
        }
    }
}
