namespace Poker.Hands
{
    abstract class Pattern: HighCard
    {
        public override int Compare(Card[] firstHand, Card[] secondHand)
        {
            if (Matches(firstHand) && Matches(secondHand))
            {
                return base.Compare(firstHand, secondHand);
            }

            return Matches(firstHand).CompareTo(Matches(secondHand));
        }

        protected abstract bool Matches(Card[] hand);
    }
}
