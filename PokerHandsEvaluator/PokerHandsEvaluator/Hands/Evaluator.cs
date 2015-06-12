using System.Collections.Generic;
using System.Linq;

namespace Poker.Hands
{
    public class Evaluator
    {
        private readonly IHand highCard = new HighCard();
        private readonly IHand onePair = new RankPattern(new[] {2, 1, 1, 1});
        private readonly IHand twoPairs = new RankPattern(new[] {2, 2, 1});
        private readonly IHand threeOfAKind = new RankPattern(new[] {3, 1, 1});
        private readonly IHand straight = new Straight();
        private readonly IHand flush = new Flush();
        private readonly IHand fullHouse = new RankPattern(new[] {2, 3});
        
        public int Compare(Card[] firstHand, Card[] secondHand)
        {
            return GetComparers()
                .Select(comparer => comparer.Compare(firstHand, secondHand))
                .FirstOrDefault(result => result != 0);
        }
        
        private IEnumerable<IHand> GetComparers()
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
