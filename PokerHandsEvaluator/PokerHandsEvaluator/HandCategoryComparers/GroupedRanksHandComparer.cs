using System;
using System.Linq;

namespace PokerHandsEvaluator.HandCategoryComparers
{
    class GroupedRanksHandComparer: IHandCategoryComparer
    {
        private readonly RanksComparer ranksComparer;
        private readonly int groupSize;
        private readonly int groupCount;

        public GroupedRanksHandComparer(int groupSize, int groupCount)
        {
            ranksComparer = new RanksComparer();
            this.groupSize = groupSize;
            this.groupCount = groupCount;
        }

        public int Compare(Card[] firstHand, Card[] secondHand)
        {
            return ranksComparer.Compare(
                GetGroupRanks(firstHand), 
                GetGroupRanks(secondHand));
        }

        private Rank[] GetGroupRanks(Card[] hand)
        {
            return GetRanks()
                .Where(rank => hand.Count(card => card.Rank == rank) == groupSize)
                .Take(groupCount).ToArray();
        }

        private Rank[] GetRanks()
        {
            return (Rank[])Enum.GetValues(typeof(Rank));
        }
    }
}
