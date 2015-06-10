namespace PokerHandsEvaluator.HandCategoryComparers
{
    interface IHandCategoryComparer
    {
        int Compare(Card[] firstHand, Card[] secondHand);
    }
}
