using CardGameStrategies.interfaces;
using Cards.Shuffle;
using GameExperiments;
using Microsoft.Extensions.Hosting;

namespace NsuLabs.Services;

public class CollisiumExperimentWorker : BackgroundService
{
    private const int ExperimentCounts = 10000;
    
    private readonly ICardGameExperiment _cardGameExperiment;
    private readonly IElonStrategy _elonStrategy;
    private readonly IMarkStrategy _markStrategy;
    private readonly IDeckShuffler _deckShuffler;

    public CollisiumExperimentWorker(ICardGameExperiment cardGameExperiment, IElonStrategy elonStrategy,
        IMarkStrategy markStrategy, IDeckShuffler deckShuffler)
    {
        this._cardGameExperiment = cardGameExperiment;
        this._elonStrategy = elonStrategy;
        this._markStrategy = markStrategy;
        this._deckShuffler = deckShuffler;
    }

    // Логика запуска экспериментов
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        
        float successCount = 0;
        for (var i = 0; i < ExperimentCounts; i++)
        {
            var experimentResult = _cardGameExperiment.RunExperiment();

            if (experimentResult)
                successCount++;
        }

        Console.WriteLine(successCount / ExperimentCounts * 100);
        return Task.CompletedTask;
    }
}