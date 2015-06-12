using System.Collections.Generic;
using System.Linq;

namespace Poker.Hands
{
    public class Evaluator
    {
        readonly Hand highCard = new HighCard();
        readonly Hand onePair = new GroupedRanksHand(2, 1);
        readonly Hand twoPairs = new GroupedRanksHand(2, 2);
        readonly Hand threeOfAKind = new GroupedRanksHand(3, 1);
        readonly Hand straight = new Straight();
        readonly Hand flush = new Flush();
        readonly Hand fullHouse = new FullHouse();
        
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
                fullHouse,
                flush,
                straight,
                threeOfAKind,
                twoPairs,
                onePair,
                highCard
            };
        }  
    }
}
