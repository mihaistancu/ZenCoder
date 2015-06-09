using NUnit.Framework;

namespace PokerHandsEvaluator
{
    public class BaseTests
    {
        protected Card[] FirstHand;
        protected Card[] SecondHand;
        protected PokerHandsEvaluator Evaluator;

        [SetUp]
        public virtual void Setup()
        {
            Evaluator = new PokerHandsEvaluator();
        }

        public void Setup(string firstHand, string secondHand)
        {
            FirstHand = PokerHand.Parse(firstHand);
            SecondHand = PokerHand.Parse(secondHand);
        }

        public void AssertFirstHandWins()
        {
            Assert.AreEqual(1, Evaluator.Compare(FirstHand, SecondHand));
            Assert.AreEqual(-1, Evaluator.Compare(SecondHand, FirstHand));
        }
    }
}
