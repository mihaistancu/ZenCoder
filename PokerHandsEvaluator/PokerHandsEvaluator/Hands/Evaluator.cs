using System.Collections.Generic;
using System.Linq;

namespace Poker.Hands
{
    public class Evaluator
    {
        private readonly Hand highCard = new HighCard();
        private readonly Hand onePair = new GroupedRanksHand(new[] {2, 1, 1, 1});
        private readonly Hand twoPairs = new GroupedRanksHand(new[] {2, 2, 1});
        private readonly Hand threeOfAKind = new GroupedRanksHand(new[] {3, 1, 1});
        private readonly Hand straight = new Straight();
        private readonly Hand flush = new Flush();
        private readonly Hand fullHouse = new GroupedRanksHand(new[] {2, 3});
        
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
