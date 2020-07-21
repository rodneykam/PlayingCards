using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayingCards
{
    public enum Rank
    {
        Ace = 0,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public enum Suit
    {
        Diamonds = 0,
        Clubs,
        Hearts,
        Spades
    }

    public class Card
    {
        private Rank rank { get; set; }
        private Suit suit { get; set; }
        
        public Card(int iRank, int iSuit)
        {
            this.rank = (Rank)iRank;
            this.suit = (Suit)iSuit;
        }

        public void ShowCard()
        {
            Console.WriteLine("{0} of {1}", rank, suit);
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

        private void RiffleShuffle()
        {
            int i = cards.Count / 2;
            int j = cards.Count - 1;

            while(i > 0)
            {
                var temp = cards[i];
                cards[i--] = cards[j];
                cards[j--] = temp;
            }
            
        }
        private void RandomShuffle()
        {
            Random rnd = new Random();
            for (int i = cards.Count-1; i > 0; i--)
            {
                int index = rnd.Next(i+1);
                var temp = cards[index];
                cards[index] = cards[i];
                cards[i] = temp;
            }
        }
        
        public void Shuffle()
        {
            RandomShuffle();
            RiffleShuffle();
        }

        public Card Deal()
        {
            var card = cards.First();
            cards.RemoveAt(0);

            return card;
        }
    }
        
}