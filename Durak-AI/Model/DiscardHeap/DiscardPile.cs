﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.PlayingCards;

namespace Model.DiscardHeap
{
    public class DiscardPile
    {
        private List<Card> discardPile = new List<Card>();
        public int GetSize() => discardPile.Count;
        public List<Card> GetCards() => discardPile;

        public DiscardPile()
        {

        }
        public DiscardPile Copy()
        {
            DiscardPile copy = (DiscardPile)this.MemberwiseClone();
            // copy the discard pile to the copy object
            copy.discardPile = new List<Card>(discardPile);
            return copy;
        }


        public void AddCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                discardPile.Add(card);
            }
        }

    }
}