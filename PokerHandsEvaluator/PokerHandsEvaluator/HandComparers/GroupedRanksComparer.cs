using System;
using System.Linq;

namespace PokerHandsEvaluator.HandComparers
{
    class GroupedRanksComparer: HandComparer
    {
        private readonly int groupSize;
        private readonly int groupCount;

        public GroupedRanksComparer(int groupSize, int groupCount)
        {
            this.groupSize = groupSize;
            this.groupCount = groupCount;
        }

        public override int Compare(Card[] firstHand, Card[] secondHand)
        {
            return Compare(
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
