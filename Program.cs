using System;
using PlayingCards;

namespace PlayingCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var cardDeck = new Deck();
            cardDeck.Shuffle();
            var topCard = cardDeck.Deal();
            topCard.ShowCard();
            
            Console.WriteLine("Hello World!");
        }
    }
}

