using CardGameStrategies.interfaces;
using Cards;
using Cards.Shuffle;

namespace GameExperiments;

public class CardGameExperiment : ICardGameExperiment
{
    private readonly IDeckShuffler _deckShuffler;
    private readonly IElonStrategy _elonStrategy;
    private readonly IMarkStrategy _markStrategy;

    public CardGameExperiment(IDeckShuffler deckShuffler, IElonStrategy elonStrategy, IMarkStrategy markStrategy)
    {
        this._deckShuffler = deckShuffler;
        this._elonStrategy = elonStrategy;
        this._markStrategy = markStrategy;
    }

    public bool RunExperiment()
    {
        var deck = _deckShuffler.GetNewShuffledDeck();
            
        var firstHalfOfDeck = deck.GetFirstDeckHalf();
        var firstColor =firstHalfOfDeck[_elonStrategy
            .Pick(firstHalfOfDeck)].Color;
    
        var secondHalfOfDeck = deck.GetSecondDeckHalf();
        var secondColor =secondHalfOfDeck[_markStrategy
            .Pick(secondHalfOfDeck)].Color;
        
        return firstColor == secondColor;
    }
 
}