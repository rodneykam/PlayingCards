using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayingCards
{
    public class Card
    {
        private string[] Suit = new string[] {"Diamonds", "Clubs", "Hearts",  "Spages"};
        private string[] Rank = new string[] {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Ten", "Jack","Queen","King"};

        public Card(int r, int s)
        {
            rank = r;
            suit = s;

        }

        private int rank { get; set; }
        private int suit { get; set; }
        
        public void ShowCard()
        {
            Console.WriteLine("{0} of {1}", Rank[rank], Suit[suit]);
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