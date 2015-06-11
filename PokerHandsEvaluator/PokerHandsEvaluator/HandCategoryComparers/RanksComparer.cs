using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerHandsEvaluator.HandCategoryComparers
{
    public class RanksComparer
    {
        public int Compare(Rank[] a, Rank[] b)
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

        public IEnumerable<Rank> SortDescending(Rank[] ranks)
        {
            return ranks.OrderByDescending(rank => rank);
        } 
    }
}