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
            
            cardDeck.Deal().ShowCard();
            cardDeck.Deal().ShowCard();
            cardDeck.Deal().ShowCard();
            cardDeck.Deal().ShowCard();
            cardDeck.Deal().ShowCard();
            cardDeck.Deal().ShowCard();
            cardDeck.Deal().ShowCard();
       }
    }
}

