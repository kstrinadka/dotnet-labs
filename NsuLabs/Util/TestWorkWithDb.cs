using Cards;
using Cards.Shuffle;
using Microsoft.EntityFrameworkCore;
using NsuLabs.data;

namespace NsuLabs.Util;

public class TestWorkWithDb
{
    
    public static void TestDb()
    {
        var dbContext = CreateDbContext();

        var deckShuffler = new DeckShuffler();
        var newShuffledDeck = deckShuffler.GetNewShuffledDeck();
        
        
        // SaveExperimentCondition(newShuffledDeck, dbContext);

        
        // Read first experiment from db
        // var firstExperiment = GetFirstExperiment(dbContext);
        // Console.WriteLine(firstExperiment.DeckOrder);
         
        
        GetAllExperimentsAndPrint(dbContext);
        
    }

    private static void GetAllExperimentsAndPrint(ExperimentContext dbContext)
    {
        // Get all saved experiments
        var experiments = dbContext.ExperimentConditions
            .ToList();

        foreach (var experiment in experiments)
        {
            Console.WriteLine(experiment.DeckOrder);
        }
        
    }

    private static void SaveExperimentCondition(Deck newShuffledDeck, ExperimentContext dbContext)
    {
        Console.WriteLine("Inserting a new blog");
        var experimentCondition = new ExperimentCondition("rbrbrbrbrbrbrbrbrbrbrbrbrbrbrbrb");
        var shuffledCondition = new ExperimentCondition(newShuffledDeck);

        dbContext.Add(shuffledCondition);
        dbContext.SaveChanges();
    }

    private static ExperimentContext CreateDbContext()
    {
        // Важно создать такой контекст для работы с БД
        var dbContext = new ExperimentContext();

        dbContext.Database.EnsureCreated();
        dbContext.ExperimentConditions.Load();
        return dbContext;
    }

    private static ExperimentCondition GetFirstExperiment(ExperimentContext dbContext)
    {
        Console.WriteLine("Querying for a blog");
        var experiment = dbContext.ExperimentConditions
            .OrderBy(e => e.Id)
            .First();
        return experiment;
    }
}