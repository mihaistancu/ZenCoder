using System.Collections.Generic;
using System.Linq;

namespace Poker.Hands
{
    class Flush: SpecialHighCard
    {
        protected override bool Matches(Card[] hand)
        {
            return GetSuits(hand).Distinct().Count() == 1;
        }

        public IEnumerable<Suit> GetSuits(Card[] hand)
        {
            return hand.Select(card => card.Suit);
        }
    }
}
