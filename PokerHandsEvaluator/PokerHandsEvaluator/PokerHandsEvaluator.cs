using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerHandsEvaluator
{
    public class PokerHandsEvaluator
    {
        public int Compare(Card[] firstHand, Card[] secondHand)
        {
            SortDescending(firstHand);
            SortDescending(secondHand);

            int result = CompareOnePairs(firstHand, secondHand);
            if (result != 0)
            {
                return result;
            }

            return CompareHighCards(firstHand, secondHand);
        }

        private void SortDescending(Card[] hand)
        {
            Array.Sort(hand, Compare);
            Array.Reverse(hand);
        }

        private int CompareOnePairs(Card[] firstHand, Card[] secondHand)
        {
            return Nullable.Compare(
                GetOnePairRank(firstHand),  
                GetOnePairRank(secondHand));
        }

        private Rank? GetOnePairRank(Card[] hand)
        {
            return (from rank in GetRanks()
                where hand.Count(card => card.Rank == rank) == 2
                select (Rank?)rank).FirstOrDefault();
        }

        private Rank[] GetRanks()
        {
            return (Rank[]) Enum.GetValues(typeof (Rank));
        }

        private int CompareHighCards(Card[] firstHand, Card[] secondHand)
        {
            return firstHand.Zip(secondHand, Compare)
                .FirstOrDefault(result => result != 0);
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
