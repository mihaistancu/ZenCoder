using System.Linq;

namespace PokerHandsEvaluator.HandComparers
{
    class HighCardComparer: HandComparer
    {
        public override int Compare(Card[] firstHand, Card[] secondHand)
        {
            return Compare(
                GetRanks(firstHand),
                GetRanks(secondHand));
        }

        private Rank[] GetRanks(Card[] hand)
        {
            return hand.Select(card => card.Rank).ToArray();
        }
    }
}
