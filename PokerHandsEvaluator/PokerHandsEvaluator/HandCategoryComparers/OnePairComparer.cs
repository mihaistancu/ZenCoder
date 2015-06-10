using System;
using System.Linq;

namespace PokerHandsEvaluator.HandCategoryComparers
{
    class OnePairComparer: IHandCategoryComparer
    {
        public int Compare(Card[] firstHand, Card[] secondHand)
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
            return (Rank[])Enum.GetValues(typeof(Rank));
        }
    }
}
