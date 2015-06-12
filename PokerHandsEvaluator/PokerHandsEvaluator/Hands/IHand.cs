namespace Poker.Hands
{
    internal interface IHand
    {
        int Compare(Card[] firstHand, Card[] secondHand);
    }
}
