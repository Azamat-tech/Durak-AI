using System;
using System.Collections.Generic;

namespace Model.PlayingCards
{
    public class Card : IEquatable<Card>
    {
        public readonly Suit suit;
        public readonly Rank rank;

        private string[] suitUnicode = { "♠", "♥", "♦", "♣" };

        public Card() { }

        public Card(Suit _suit, Rank _rank)
        {
            suit = _suit;
            rank = _rank;
        }
        public string GetRank(int value) =>
            value < 11 ? value.ToString() : "JQKA"[value - 11].ToString();

        public string GetSuit(int index) =>
            suitUnicode[index];

        public bool HighValueRank() =>
            (int)this.rank - 6 >= 0 ? true : false;

        public override string ToString() =>
            GetRank((int)rank) + "" + GetSuit((int)suit) + " ";

        public bool Equals(Card ?other) => 
            other is Card c && suit == c.suit && rank == c.rank;
    }
}
