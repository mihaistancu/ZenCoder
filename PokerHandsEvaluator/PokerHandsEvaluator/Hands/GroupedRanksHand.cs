using System.Linq;

namespace Poker.Hands
{
    class GroupedRanksHand: Hand
    {
        private readonly int groupSize;
        private readonly int groupCount;

        public GroupedRanksHand(int groupSize, int groupCount)
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
    }
}
