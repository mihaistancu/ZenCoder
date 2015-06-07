using NUnit.Framework;

namespace PokerHandsEvaluator
{
    public class HighCardTests
    {
        private Card[] firstHand;
        private Card[] secondHand;
        private PokerHandsEvaluator evaluator;

        [SetUp]
        public void Setup()
        {
            firstHand = GetVeryBadHand();
            secondHand = GetVeryBadHand();
            evaluator = new PokerHandsEvaluator();
        }

        private Card[] GetVeryBadHand()
        {
            return new []{
                new Card(Rank.Two, Suit.Hearts),
                new Card(Rank.Three, Suit.Clubs),
                new Card(Rank.Five, Suit.Spades),
                new Card(Rank.Six, Suit.Diamonds),
                new Card(Rank.Eight, Suit.Hearts)
            };
        }

        [TestCase(Rank.Ace, Rank.King)]
        [TestCase(Rank.King, Rank.Queen)]
        [TestCase(Rank.Queen, Rank.Jack)]
        [TestCase(Rank.Jack, Rank.Ten)]
        [TestCase(Rank.Ten, Rank.Nine)]
        [TestCase(Rank.Nine, Rank.Eight)]
        [TestCase(Rank.Eight, Rank.Seven)]
        [TestCase(Rank.Seven, Rank.Six)]
        [TestCase(Rank.Six, Rank.Five)]
        [TestCase(Rank.Five, Rank.Four)]
        [TestCase(Rank.Four, Rank.Three)]
        [TestCase(Rank.Three, Rank.Two)]
        public void HighestRankWins(Rank firstHandHighCard, Rank secondHandHighCard)
        {
            firstHand[0] = new Card(firstHandHighCard, Suit.Clubs);
            secondHand[0] = new Card(secondHandHighCard, Suit.Diamonds);
            
            Assert.AreEqual(1, evaluator.Compare(firstHand, secondHand));
            Assert.AreEqual(-1, evaluator.Compare(secondHand, firstHand));
        }
    }
}
