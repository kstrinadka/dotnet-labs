using Cards.Card;

namespace Cards;

public class Deck
{
    public const int HalfDeckSize = 18;  // Половина размера колоды
    public const int DeckSize = 36;      // Полный размер колоды
    
    public Card.Card[] WholeDeck { get; set; }
    public Card.Card[] FirstPartOfDeck { get; set; }
    public Card.Card[] SecondPartOfDeck { get; set; }

    public Deck()
    {
        WholeDeck = CreateAndGetDeck();
        UpdateHalfs();
    }
    
    // обновить половинки колод исходя из всей колоды
    public void UpdateHalfs()
    {
        FirstPartOfDeck = SubArray(WholeDeck, 0, HalfDeckSize);
        SecondPartOfDeck = SubArray(WholeDeck, HalfDeckSize, HalfDeckSize);
    }

    // Shuffler использует этот метод для перемешивания колоды
    public void SwapCards(int firstIndex, int secondIndex)
    {
        (WholeDeck[firstIndex], WholeDeck[secondIndex]) = (WholeDeck[secondIndex], WholeDeck[firstIndex]);
        UpdateHalfs();
    }
    
    private static Card.Card[] CreateAndGetDeck()
    {
        var deck = new Card.Card[DeckSize];
        for (var index = 0; index < HalfDeckSize; index++)
        {
            deck[index] = new Card.Card(CardColor.Red);
        }

        for (var index = HalfDeckSize; index < DeckSize; index++)
        {
            deck[index] = new Card.Card(CardColor.Black);
        }

        return deck;
    }
    
    private static T[] SubArray<T>(T[] array, int index, int length)
    {
        T[] result = new T[length];
        Array.Copy(array, index, result, 0, length);
        return result;
    }
}