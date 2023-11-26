using CardGameStrategies.interfaces;
using Cards;
using Cards.Shuffle;

namespace GameExperiments;

public class CardGameExperiment : ICardGameExperiment
{
    private readonly IDeckShuffler _deckShuffler;

    public CardGameExperiment(IDeckShuffler deckShuffler)
    {
        this._deckShuffler = deckShuffler;
    }

    public bool RunExperiment(ICardPickStrategy elonStrategy, ICardPickStrategy markStrategy)
    {
        
        var deck = _deckShuffler.GetNewShuffledDeck();
            
        var firstHalfOfDeck = deck.FirstPartOfDeck;
        var firstColor =firstHalfOfDeck[elonStrategy
            .Pick(firstHalfOfDeck)].Color;
    
        var secondHalfOfDeck = deck.SecondPartOfDeck;
        var secondColor =secondHalfOfDeck[markStrategy
            .Pick(secondHalfOfDeck)].Color;
        
        return firstColor == secondColor;
    }
    
    public static bool RunExperiment(ICardPickStrategy elonStrategy, ICardPickStrategy markStrategy, Deck deck)
    {
        
        var firstHalfOfDeck = deck.FirstPartOfDeck;
        var firstColor = firstHalfOfDeck[elonStrategy
            .Pick(firstHalfOfDeck)].Color;
    
        var secondHalfOfDeck = deck.SecondPartOfDeck;
        var secondColor = secondHalfOfDeck[markStrategy
            .Pick(secondHalfOfDeck)].Color;
        
        return firstColor == secondColor;
    }

 
}