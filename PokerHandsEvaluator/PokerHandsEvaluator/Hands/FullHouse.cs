using System.Linq;

namespace Poker.Hands
{
    class FullHouse: SpecialHighCard
    {
        protected override bool Matches(Card[] hand)
        {
            return GetRanks(hand).Distinct()
                .Select(rank => hand.Count(card => card.Rank == rank))
                .OrderByDescending(count => count).SequenceEqual(new[] {3, 2});
        }
    }
}
