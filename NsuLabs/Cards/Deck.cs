namespace NsuLabs.Cards;

public class Deck
{
    // размер колоды
    private const int HalfDeckSize = 18;
    private const int DeckSize = 36;

    // колода
    private readonly Card[] _firstPartOfDeckDeck = new Card[HalfDeckSize];
    public Card[] FirstPartOfDeckDeck => _firstPartOfDeckDeck;

    private readonly Card[] _secondPartOfDeck = new Card[HalfDeckSize];
    public Card[] SecondPartOfDeck => _secondPartOfDeck;

    private readonly Card[] _wholeDeck = new Card[DeckSize];
    public Card[] WholeDeck => _wholeDeck;


    private readonly Random _random = new Random();


    public Deck()
    {
        ShuffleDeck();
        FillDeckHalfs();
    }

    private void ShuffleDeck()
    {
        for (var index = 0; index < DeckSize; index++)
        {
            if (_random.Next(0, 2) == 1)
            {
                _wholeDeck[index] = new Card(CardColor.Red);
            }
            else
            {
                _wholeDeck[index] = new Card(CardColor.Black);
            }
        }
    }

    private void FillDeckHalfs()
    {
        for (var index = 0; index < HalfDeckSize; index++)
        {
            _firstPartOfDeckDeck[index] = _wholeDeck[index];
        }

        for (var index = HalfDeckSize; index < DeckSize; index++)
        {
            _secondPartOfDeck[index - HalfDeckSize] = _wholeDeck[index];
        }
    }
}