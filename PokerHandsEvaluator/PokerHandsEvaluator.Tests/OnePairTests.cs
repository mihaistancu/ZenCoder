using NUnit.Framework;

namespace PokerHandsEvaluator
{
    public class OnePairTests: BaseTests
    {
        private Card[] GetOnePairHand(Rank rank)
        {
            return new[]{
                new Card(rank, Suit.Hearts),
                new Card(rank, Suit.Clubs),
                new Card(Rank.Five, Suit.Spades),
                new Card(Rank.Six, Suit.Diamonds),
                new Card(Rank.Eight, Suit.Hearts)
            };
        }

        [Test]
        public void HighestPairWins()
        {
            firstHand = GetOnePairHand(Rank.Ace);
            secondHand = GetOnePairHand(Rank.King);

            AssertFirstHandWins();
        }
    }
}
