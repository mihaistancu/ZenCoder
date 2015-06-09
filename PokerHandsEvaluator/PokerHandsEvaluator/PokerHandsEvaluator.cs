using System.Linq;

namespace PokerHandsEvaluator
{
    public class PokerHandsEvaluator
    {
        public int Compare(Card[] firstHand, Card[] secondHand)
        {   
            return firstHand.Max(card => card.Rank) - secondHand.Max(card => card.Rank);
        }
    }
}
