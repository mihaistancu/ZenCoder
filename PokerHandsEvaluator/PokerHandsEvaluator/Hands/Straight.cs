using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker.Hands
{
    internal class Straight: Pattern
    {
        internal override bool Matches(Card[] hand)
        {
            var ranks = GetRanks(hand);

            return AreEqual(ranks, GetStraightStartingAt(ranks.Min()));
        }

        protected bool AreEqual(IEnumerable<Rank> a, IEnumerable<Rank> b)
        {
            return SortDescending(a).SequenceEqual(SortDescending(b));
        }

        private IEnumerable<Rank> GetStraightStartingAt(Rank startRank)
        {
            int startIndex = Array.IndexOf(GetRanks(), startRank);
            return GetRanks().Skip(startIndex).Take(5);
        }

        private Rank[] GetRanks()
        {
            return (Rank[])Enum.GetValues(typeof(Rank));
        }
    }
}
