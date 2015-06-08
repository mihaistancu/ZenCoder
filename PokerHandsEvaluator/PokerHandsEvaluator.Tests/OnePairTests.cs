using NUnit.Framework;

namespace PokerHandsEvaluator
{
    public class OnePairTests
    {
        private Card[] firstHand;
        private Card[] secondHand;
        private PokerHandsEvaluator evaluator;

        [SetUp]
        public void Setup()
        {
            evaluator = new PokerHandsEvaluator();
        }

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

            Assert.AreEqual(1, evaluator.Compare(firstHand, secondHand));
            Assert.AreEqual(-1, evaluator.Compare(secondHand, firstHand));
        }
    }
}
