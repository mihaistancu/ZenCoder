namespace Poker.Hands
{
    class BabyStraightFlush: BabyStraight
    {
        private readonly Flush flush = new Flush();

        internal override bool Matches(Card[] hand)
        {
            return base.Matches(hand) && flush.Matches(hand);
        }
    }
}
