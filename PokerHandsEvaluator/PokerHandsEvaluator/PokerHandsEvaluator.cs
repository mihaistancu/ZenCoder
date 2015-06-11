using System.Collections.Generic;
using System.Linq;
using PokerHandsEvaluator.HandCategoryComparers;

namespace PokerHandsEvaluator
{
    public class PokerHandsEvaluator
    {
        readonly IHandCategoryComparer highCardComparer = new HighCardComparer();
        readonly IHandCategoryComparer onePairComparer = new GroupedRanksHandComparer(2, 1);
        readonly IHandCategoryComparer twoPairsComparer = new GroupedRanksHandComparer(2, 2);
        readonly IHandCategoryComparer threeOfAKindComparer = new GroupedRanksHandComparer(3, 1);
        
        public int Compare(Card[] firstHand, Card[] secondHand)
        {
            return GetComparers()
                .Select(comparer => comparer.Compare(firstHand, secondHand))
                .FirstOrDefault(result => result != 0);
        }
        
        private IEnumerable<IHandCategoryComparer> GetComparers()
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
