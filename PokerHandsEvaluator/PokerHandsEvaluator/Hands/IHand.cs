namespace Poker.Hands
{
    interface IHand
    {
        int Compare(Card[] firstHand, Card[] secondHand);
    }
}
