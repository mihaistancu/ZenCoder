using NUnit.Framework;

namespace PokerHandsEvaluator
{
    public class BaseTests
    {
        protected PokerHandsEvaluator Evaluator;

        [SetUp]
        public virtual void Setup()
        {
            Evaluator = new PokerHandsEvaluator();
        }

        public void AssertFirstHandWins(string firstHandSerialized, string secondHandSerialized)
        {
            Card[] firstHand = PokerHand.Parse(firstHandSerialized);
            Card[] secondHand = PokerHand.Parse(secondHandSerialized);

            Assert.AreEqual(1, Evaluator.Compare(firstHand, secondHand));
            Assert.AreEqual(-1, Evaluator.Compare(secondHand, firstHand));
        }
    }
}
