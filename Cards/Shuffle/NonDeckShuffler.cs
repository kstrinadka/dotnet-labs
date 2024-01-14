namespace Cards.Shuffle;

public class NonDeckShuffler: IDeckShuffler
{
    private Deck _deck;
    
    public NonDeckShuffler(Deck deck)
    {
        _deck = deck;
    }

    public Deck Shuffle(Deck deck)
    {
        return deck;
    }

    public Deck GetNewShuffledDeck()
    {
        return _deck;
    }
}