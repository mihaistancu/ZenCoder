using NUnit.Framework;

namespace PokerHandsEvaluator
{
    public class BaseTests
    {
        protected Card[] FirstHand;
        protected Card[] SecondHand;
        protected PokerHandsEvaluator Evaluator;

        [SetUp]
        public void Setup()
        {
            Evaluator = new PokerHandsEvaluator();
        }

        protected void Setup(string firstHand, string secondHand)
        {
            FirstHand = PokerHandParser.Parse(firstHand);
            SecondHand = PokerHandParser.Parse(secondHand);
        }

        protected void AssertFirstHandWins(string firstHand, string secondHand)
        {
            Setup(firstHand, secondHand);

            Assert.AreEqual(1, Evaluator.Compare(FirstHand, SecondHand));
            Assert.AreEqual(-1, Evaluator.Compare(SecondHand, FirstHand));
        }
    }
}
