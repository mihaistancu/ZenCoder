using System;
using System.Linq;

namespace PokerHandsEvaluator.HandCategoryComparers
{
    class HighCardComparer: IHandCategoryComparer
    {
        public int Compare(Card[] firstHand, Card[] secondHand)
        {
            SortDescending(firstHand);
            SortDescending(secondHand);

            return firstHand.Zip(secondHand, Compare)
                .FirstOrDefault(result => result != 0);
        }

        private void SortDescending(Card[] hand)
        {
            Array.Sort(hand, Compare);
            Array.Reverse(hand);
        }

        private int Compare(Card a, Card b)
        {
            return Compare(a.Rank, b.Rank);
        }

        private int Compare(Rank a, Rank b)
        {
            return Math.Sign(a - b);
        }
    }
}
