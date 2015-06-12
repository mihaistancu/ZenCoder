using System.Collections.Generic;
using System.Linq;

namespace Poker.Hands
{
    internal class HighCard: IHand
    {
        public virtual int Compare(Card[] firstHand, Card[] secondHand)
        {
            return SortDescending(GetRanks(firstHand))
                .Zip(SortDescending(GetRanks(secondHand)), (x, y) => x.CompareTo(y))
                .FirstOrDefault(comparison => comparison != 0);
        }

        protected IEnumerable<Rank> SortDescending(IEnumerable<Rank> ranks)
        {
            return ranks.OrderByDescending(rank => rank);
        }

        protected Rank[] GetRanks(IEnumerable<Card> hand)
        {
            return hand.Select(card => card.Rank).ToArray();
        }
    }
}
