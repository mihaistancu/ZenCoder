using NUnit.Framework;

namespace PokerHandsEvaluator
{
    public class EqualCardsTests: BaseTests
    {
        [TestCase("As Kc 5s 6d 8h", "Kd Ah 5c 8d 6h")]
        public void NoOneWins(string firstHand, string secondHand)
        {
            Setup(firstHand, secondHand);

            Assert.AreEqual(0, Evaluator.Compare(FirstHand, SecondHand));
        }
    }
}
