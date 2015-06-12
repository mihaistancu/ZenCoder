using System.Collections.Generic;

namespace Poker.Hands
{
    class BabyStraight: Straight
    {
        internal override bool Matches(Card[] hand)
        {
            return AreEqual(GetRanks(hand), GetBabyStraight());
        }

        private IEnumerable<Rank> GetBabyStraight()
        {
            return new[] { Rank.Ace, Rank.Two, Rank.Three, Rank.Four, Rank.Five };
        }
    }
}
