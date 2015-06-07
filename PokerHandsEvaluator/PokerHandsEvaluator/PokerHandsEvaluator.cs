using System;

namespace PokerHandsEvaluator
{
    public class PokerHandsEvaluator
    {
        public int Compare(Card[] firstHand, Card[] secondHand)
        {
            var rankOrder = new[]
            {
                Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten,
                Rank.Jack, Rank.Queen, Rank.King, Rank.Ace
            };

            var firstHandMaxRank = Array.IndexOf(rankOrder, firstHand[0].Rank);
            var secondHandMaxRank = Array.IndexOf(rankOrder, secondHand[0].Rank);

            return firstHandMaxRank.CompareTo(secondHandMaxRank);
        }
    }
}
