using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PokerHandsEvaluator
{
    [TestClass]
    public class HighCardTests
    {
        private Card[] firstHand;
        private Card[] secondHand;
        private PokerHandsEvaluator evaluator;

        [TestInitialize]
        public void Setup()
        {
            firstHand = GetHighCardHand();
            secondHand = GetHighCardHand();
            evaluator = new PokerHandsEvaluator();
        }

        private Card[] GetHighCardHand()
        {
            return new []{
                new Card(Rank.Two, Suit.Hearts),
                new Card(Rank.Three, Suit.Clubs),
                new Card(Rank.Five, Suit.Spades),
                new Card(Rank.Six, Suit.Diamonds),
                new Card(Rank.Eight, Suit.Hearts)
            };
        }

        [TestMethod]
        public void AnAceBeatsAKing()
        {
            firstHand[0] = new Card(Rank.Ace, Suit.Clubs);
            secondHand[0] = new Card(Rank.King, Suit.Diamonds);
            Assert.AreEqual(1, evaluator.Compare(firstHand, secondHand));
        }

        [TestMethod]
        public void AKingBeatsAQueen()
        {
            firstHand[0] = new Card(Rank.King, Suit.Clubs);
            secondHand[0] = new Card(Rank.Queen, Suit.Diamonds);
            Assert.AreEqual(1, evaluator.Compare(firstHand, secondHand));
        }
    }
}
