using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker.Hands
{
    abstract class Hand
    {
        public abstract int Compare(Card[] firstHand, Card[] secondHand);

        public bool Matches()
        {
            return true;
        }

        protected int Compare(Rank[] a, Rank[] b)
        {
            int result = a.Length.CompareTo(b.Length);

            if (result != 0)
            {
                return result;
            }

            return SortDescending(a)
                .Zip(SortDescending(b), (x, y) => x.CompareTo(y))
                .FirstOrDefault(comparison => comparison != 0);
        }

        protected IEnumerable<Rank> SortDescending(IEnumerable<Rank> ranks)
        {
            return ranks.OrderByDescending(rank => rank);
        }

        protected Rank[] GetRanks()
        {
            return (Rank[])Enum.GetValues(typeof(Rank));
        }
    }
}
