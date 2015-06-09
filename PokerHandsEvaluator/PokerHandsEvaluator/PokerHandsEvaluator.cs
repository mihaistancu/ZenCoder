using System;
using System.Linq;

namespace PokerHandsEvaluator
{
    public class PokerHandsEvaluator
    {
        public int Compare(Card[] firstHand, Card[] secondHand)
        {
            SortDescending(firstHand);
            SortDescending(secondHand);

            var results = firstHand.Zip(secondHand, Compare);

            return results.FirstOrDefault(result => result != 0);
        }

        private void SortDescending(Card[] hand)
        {
            Array.Sort(hand, Compare);
            Array.Reverse(hand);
        }

        private int Compare(Card a, Card b)
        {
            return Math.Sign(a.Rank - b.Rank);
        }
    }
}
