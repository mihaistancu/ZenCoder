namespace Poker.Hands
{
    internal class StraightFlush: Pattern
    {
        private readonly Straight straight = new Straight();
        private readonly Flush flush = new Flush();

        internal override bool Matches(Card[] hand)
        {
            return straight.Matches(hand) && flush.Matches(hand);
        }
    }
}
