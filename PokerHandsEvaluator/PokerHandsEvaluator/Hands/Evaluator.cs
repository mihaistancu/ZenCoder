using System.Collections.Generic;
using System.Linq;

namespace Poker.Hands
{
    public class Evaluator
    {
        readonly Hand highCardComparer = new HighCard();
        readonly Hand onePairComparer = new GroupedRanksHand(2, 1);
        readonly Hand twoPairsComparer = new GroupedRanksHand(2, 2);
        readonly Hand threeOfAKindComparer = new GroupedRanksHand(3, 1);
        readonly Hand straightComparer = new Straight();
        
        public int Compare(Card[] firstHand, Card[] secondHand)
        {
            return GetComparers()
                .Select(comparer => comparer.Compare(firstHand, secondHand))
                .FirstOrDefault(result => result != 0);
        }
        
        private IEnumerable<Hand> GetComparers()
        {
            return new []
            {
                straightComparer,
                threeOfAKindComparer,
                twoPairsComparer,
                onePairComparer,
                highCardComparer
            };
        }  
    }
}
