using System.Collections.Generic;
using System.Linq;

namespace PokerHandsEvaluator
{
    public class PokerHandParser
    {
        private static readonly Dictionary<char, Rank> ranks = new Dictionary<char, Rank>
        {
            {'A', Rank.Ace},
            {'2', Rank.Two},
            {'3', Rank.Three},
            {'4', Rank.Four},
            {'5', Rank.Five},
            {'6', Rank.Six},
            {'7', Rank.Seven},
            {'8', Rank.Eight},
            {'9', Rank.Nine},
            {'0', Rank.Ten},
            {'J', Rank.Jack},
            {'Q', Rank.Queen},
            {'K', Rank.King}
        };

        private static readonly Dictionary<char, Suit> suits = new Dictionary<char, Suit>
        {
            {'h', Suit.Hearts},
            {'s', Suit.Spades},
            {'c', Suit.Clubs},
            {'d', Suit.Diamonds}
        };

        public static Card[] Parse(string hand)
        {
            return hand.Split(' ')
                .Select(card => new Card(ranks[card[0]], suits[card[1]]))
                .ToArray();
        }
    }
}