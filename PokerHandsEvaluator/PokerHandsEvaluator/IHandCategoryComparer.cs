namespace PokerHandsEvaluator
{
    interface IHandCategoryComparer
    {
        int Compare(Card[] firstHand, Card[] secondHand);
    }
}
