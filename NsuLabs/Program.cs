// See https://aka.ms/new-console-template for more information

using NsuLabs;
using NsuLabs.Cards;
using NsuLabs.Strategies;

const int experimentCounts = 10000;

float successCount = 0;
for (var i = 0; i < experimentCounts; i++)
{
    var cardShuffler = new DeckShuffler();
    var deck = new Deck();
    
    var firstHalfOfDeck = deck.FirstPartOfDeckDeck;
    var firstColor =firstHalfOfDeck[PickFirstStrategy
        .GetCardNumber(firstHalfOfDeck)].Color;
    
    
    var secondHalfOfDeck = deck.SecondPartOfDeck;
    var secondColor =secondHalfOfDeck[PickFirstStrategy
        .GetCardNumber(secondHalfOfDeck)].Color;
    
    if (firstColor == secondColor)
        successCount++;
}

Console.WriteLine(successCount / experimentCounts * 100);