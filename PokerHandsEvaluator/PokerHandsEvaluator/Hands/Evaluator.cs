using System.Collections.Generic;
using System.Linq;

namespace Poker.Hands
{
    public class Evaluator
    {
        public int Compare(Card[] firstHand, Card[] secondHand)
        {
            return GetHandCategories()
                .Select(hand => hand.Compare(firstHand, secondHand))
                .FirstOrDefault(result => result != 0);
        }
        
        private IEnumerable<IHand> GetHandCategories()
        {
            return new IHand[]
            {
                new StraightFlush(),
                new RankPattern(new[] {4, 1}),
                new RankPattern(new[] {2, 3}),
                new Flush(),
                new Straight(),
                new RankPattern(new[] {3, 1, 1}),
                new RankPattern(new[] {2, 2, 1}),
                new RankPattern(new[] {2, 1, 1, 1}),
                new HighCard()
            };
        }  
    }
}
