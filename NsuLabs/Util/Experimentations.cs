using CardGameStrategies;
using Cards.Shuffle;


namespace NsuLabs.Util;

public class Experimentations
{

    public static void DoExperiments()
    {
        const int experimentCounts = 10000;

        IDeckShuffler deckShuffler = new DeckShuffler();

        float successCount = 0;
        for (var i = 0; i < experimentCounts; i++)
        {
            var deck = deckShuffler.GetNewShuffledDeck();
            
            var firstHalfOfDeck = deck.FirstPartOfDeck;
            var firstColor =firstHalfOfDeck[PickFirstStrategy
                .GetCardNumber(firstHalfOfDeck)].Color;
    
            var secondHalfOfDeck = deck.SecondPartOfDeck;
            var secondColor =secondHalfOfDeck[PickFirstStrategy
                .GetCardNumber(secondHalfOfDeck)].Color;
    
            if (firstColor == secondColor)
                successCount++;
        }

        Console.WriteLine(successCount / experimentCounts * 100);
    }
    
    
}