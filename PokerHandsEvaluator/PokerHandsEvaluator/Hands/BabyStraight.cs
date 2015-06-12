using System.Collections.Generic;

namespace Poker.Hands
{
    class BabyStraight: Straight
    {
        internal override bool Matches(Card[] hand)
        {
            return AreEqual(GetRanks(hand), GetBabyStraightRanks());
        }

        private IEnumerable<Rank> GetBabyStraightRanks()
        {
            return new[] { Rank.Ace, Rank.Two, Rank.Three, Rank.Four, Rank.Five };
        }
    }
}
