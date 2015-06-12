using System.Collections.Generic;
using System.Linq;

namespace Poker.Hands
{
    class GroupedRanksHand: SpecialHighCard
    {
        private readonly int[] expectedGroupLengths;

        public GroupedRanksHand(int[] expectedGroupLengths)
        {
            this.expectedGroupLengths = expectedGroupLengths;
        }

        protected override bool Matches(Card[] hand)
        {
            return AreEqual(expectedGroupLengths, GetGroupLengths(hand));
        }

        private bool AreEqual(IEnumerable<int> a, IEnumerable<int> b)
        {
            return Sort(a).SequenceEqual(Sort(b));
        }

        private IEnumerable<int> Sort(IEnumerable<int> values)
        {
            return values.OrderBy(value => value);
        }

        private IEnumerable<int> GetGroupLengths(Card[] hand)
        {
            return GetRanks(hand).Distinct()
                .Select(rank => hand.Count(card => card.Rank == rank));
        }
    }
}
