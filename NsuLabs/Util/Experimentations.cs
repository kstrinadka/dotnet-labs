using CardGameStrategies;
using Cards.Shuffle;
using GameExperiments;


namespace NsuLabs.Util;

public class Experimentations
{

    public static void DoExperiments()
    {
        const int experimentCounts = 10000;

        var deckShuffler = new DeckShuffler();
        var cardGameExperiment = new CardGameExperiment(deckShuffler);
        var firstGameStrategy = new PickFirstStrategy();
        var secondGameStrategy = new PickFirstStrategy();

        float successCount = 0;
        for (var i = 0; i < experimentCounts; i++)
        {
            var experimentResult = cardGameExperiment
                .RunExperiment(firstGameStrategy, secondGameStrategy);

            if (experimentResult)
                successCount++;
        }

        Console.WriteLine(successCount / experimentCounts * 100);
    }
    
    
}