using System.Linq;

namespace PokerHandsEvaluator.HandCategoryComparers
{
    class HighCardComparer: IHandCategoryComparer
    {
        private readonly RanksComparer ranksComparer = new RanksComparer();

        public int Compare(Card[] firstHand, Card[] secondHand)
        {
            return ranksComparer.Compare(
                GetRanks(firstHand),
                GetRanks(secondHand));
        }

        private Rank[] GetRanks(Card[] hand)
        {
            return hand.Select(card => card.Rank).ToArray();
        }
    }
}
