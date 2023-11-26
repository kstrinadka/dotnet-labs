using CardGameStrategies;
using CardGameStrategies.interfaces;
using Cards;
using Cards.Card;
using Cards.Shuffle;
using GameExperiments;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }
    
    // Тест колоды карт.
    // Проверить, что колода карт должна иметь по 18 черных и 18 красных карт;
    [Test]
    public void TestCardColors()
    {
        var deck = new Deck();
        var cards = deck.WholeDeck;
        int redCards = 0;
        int blackCards = 0;
        
        foreach (Card card in cards)
        {
            if (card.Color == CardColor.Black)
            {
                blackCards++;
            }
            if (card.Color == CardColor.Red)
            {
                redCards++;
            }
        }

        Assert.That(redCards, Is.EqualTo(18));
        Assert.That(blackCards, Is.EqualTo(18));
    }
    
    // Тесты на стратегию.
    // Проверить, что стратегия должна давать определённый результат на определенным образом перемешанную половину колоды;
    [Test]
    public void TestStrategy()
    {
        const int halfDeckSize = 18;  
        const int deckSize = 36;     
        var cards = new Card[deckSize];
        
        for (var index = 0; index < deckSize; index++)
        {
            if (index % 2 == 0)
            {
                cards[index] = new Card(CardColor.Black);
            }
            else
            {
                cards[index] = new Card(CardColor.Red);
            }
            
        }

        var deck = new Deck();
        deck.WholeDeck = cards;
        deck.UpdateHalfs();

        ICardPickStrategy elonStrategy = new ElonMaskStrategy();
        ICardPickStrategy markStrategy = new MarkZuckerbergStrategy();
        
        var experimentResult = CardGameExperiment.RunExperiment(elonStrategy, markStrategy, deck);
        Assert.True(experimentResult);
        
        elonStrategy = new PickFirstStrategy();
        markStrategy = new PickSecondStrategy();
        experimentResult = CardGameExperiment.RunExperiment(elonStrategy, markStrategy, deck);
        Assert.False(experimentResult);
    }
    
    // Колода должна быть перемешана. Т.е. метод перемешивания должен быть вызван один раз;
    [Test]
    public void TestShuffle()
    {
        var deck = new Deck();
        var deckShuffler = new DeckShuffler();

        deckShuffler.Shuffle(deck);

        // Если в первой половине красных < 18 карт, то колода перемешивалась
        int redCards = 0;
        foreach (var card in deck.FirstPartOfDeck)
        {
            if (card.Color == CardColor.Black)
            {
                redCards++;
            }
        }

        Console.WriteLine(redCards);
        Assert.That(redCards < 18);
    }
}