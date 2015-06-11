using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerHandsEvaluator.HandComparers
{
    abstract class HandComparer
    {
        public abstract int Compare(Card[] firstHand, Card[] secondHand);

        protected Rank[] GetRanks(Card[] hand)
        {
            return hand.Select(card => card.Rank).ToArray();
        }

        protected int Compare(Rank[] a, Rank[] b)
        {
            if (a.Length < b.Length)
            {
                return -1;
            }

            if (a.Length > b.Length)
            {
                return 1;
            }

            return SortDescending(a)
                .Zip(SortDescending(b), (x, y) => Math.Sign(x - y))
                .FirstOrDefault(result => result != 0);
        }

        protected IEnumerable<Rank> SortDescending(Rank[] ranks)
        {
            return ranks.OrderByDescending(rank => rank);
        } 
    }
}
