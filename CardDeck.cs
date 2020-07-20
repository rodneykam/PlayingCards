using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayingCards
{
    public class Card
    {

        public Card(int r, int s)
        {
            rank = r;
            suit = s;

        }

        private int rank { get; set; }
        private int suit { get; set; }
        
        public void ShowCard()
        {
            Console.WriteLine("Rank: {0} Suit: {1}", this.rank, this.suit);
        }
    }

    public class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    var card = new Card(j, i);
                    cards.Add(card);
                }
            }

        }

        public void Shuffle()
        {

        }

        public Card Deal()
        {
            return cards.First();
        }
    }
        
}