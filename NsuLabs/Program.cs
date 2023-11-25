// See https://aka.ms/new-console-template for more information

using NsuLabs;
using NsuLabs.Cards;
using NsuLabs.Strategies;

const int experimentCounts = 10000;

float successCount = 0;
for (var i = 0; i < experimentCounts; i++)
{
    var deck = new Deck();
    var firstHalfOfDeck = deck.FirstPartOfDeckDeck;
    var firstColor =firstHalfOfDeck[PickFirstStrategy
        .GetCardNumber(firstHalfOfDeck)].Color;
    // Console.WriteLine("first color is " + firstColor);
    
    var secondHalfOfDeck = deck.SecondPartOfDeck;
    var secondColor =secondHalfOfDeck[PickFirstStrategy
        .GetCardNumber(secondHalfOfDeck)].Color;
    // Console.WriteLine("second color is " + secondColor);
    
    if (firstColor == secondColor)
        successCount++;
}

Console.WriteLine(successCount / experimentCounts * 100);