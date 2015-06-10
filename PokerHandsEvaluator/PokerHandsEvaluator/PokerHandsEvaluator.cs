using System.Collections.Generic;
using System.Linq;

namespace PokerHandsEvaluator
{
    public class PokerHandsEvaluator
    {
        public int Compare(Card[] firstHand, Card[] secondHand)
        {
            var comparers = new List<IHandCategoryComparer>
            {
                new OnePairComparer(),
                new HighCardComparer()
            };

            return comparers
                .Select(comparer => comparer.Compare(firstHand, secondHand))
                .FirstOrDefault(result => result != 0);
        }
    }
}
