using System.Collections.Generic;
using System.Linq;
using PokerHandsEvaluator.HandComparers;

namespace PokerHandsEvaluator
{
    public class PokerHandsEvaluator
    {
        readonly HandComparer highCardComparer = new HighCardComparer();
        readonly HandComparer onePairComparer = new GroupedRanksComparer(2, 1);
        readonly HandComparer twoPairsComparer = new GroupedRanksComparer(2, 2);
        readonly HandComparer threeOfAKindComparer = new GroupedRanksComparer(3, 1);
        
        public int Compare(Card[] firstHand, Card[] secondHand)
        {
            return GetComparers()
                .Select(comparer => comparer.Compare(firstHand, secondHand))
                .FirstOrDefault(result => result != 0);
        }

        private IEnumerable<HandComparer> GetComparers()
        {
            return new []
            {
                threeOfAKindComparer,
                twoPairsComparer,
                onePairComparer,
                highCardComparer
            };
        }  
    }
}
