using NUnit.Framework;

namespace PokerHandsEvaluator
{
    public class BaseTests
    {
        protected Card[] firstHand;
        protected Card[] secondHand;
        protected PokerHandsEvaluator evaluator;

        [SetUp]
        public virtual void Setup()
        {
            evaluator = new PokerHandsEvaluator();
        }

        public void AssertFirstHandWins()
        {
            Assert.AreEqual(1, evaluator.Compare(firstHand, secondHand));
            Assert.AreEqual(-1, evaluator.Compare(secondHand, firstHand));
        }
    }
}
