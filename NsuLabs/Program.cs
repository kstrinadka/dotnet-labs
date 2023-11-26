// See https://aka.ms/new-console-template for more information

using CardGameStrategies;
using CardGameStrategies.interfaces;
using Cards.Shuffle;
using GameExperiments;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NsuLabs.Services;


IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<CollisiumExperimentWorker>();
        services.AddScoped<IDeckShuffler, DeckShuffler>();
        services.AddScoped<IElonStrategy, ElonMaskStrategy>();
        services.AddScoped<IMarkStrategy, MarkZuckerbergStrategy>();
        services.AddScoped<ICardGameExperiment, CardGameExperiment>();
    })
    .Build();

host.Run();