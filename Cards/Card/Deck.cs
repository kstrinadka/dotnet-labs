using Cards.Card;
using NsuLabs.Util;

namespace Cards;

public class Deck
{
    
    public Card.Card[] WholeDeck { get; set; } = CreateAndGetDeck();

    public Card.Card[] GetFirstDeckHalf()
    {
        return SubArray(WholeDeck, 0, ProgramConstants.HalfDeckSize);
    }
    
    public Card.Card[] GetSecondDeckHalf()
    {
        return SubArray(WholeDeck, ProgramConstants.HalfDeckSize, ProgramConstants.HalfDeckSize);
    }

    // Shuffler использует этот метод для перемешивания колоды
    public void SwapCards(int firstIndex, int secondIndex)
    {
        (WholeDeck[firstIndex], WholeDeck[secondIndex]) = (WholeDeck[secondIndex], WholeDeck[firstIndex]);
    }
    
    private static Card.Card[] CreateAndGetDeck()
    {
        var deck = new Card.Card[ProgramConstants.DeckSize];
        for (var index = 0; index < ProgramConstants.HalfDeckSize; index++)
        {
            deck[index] = new Card.Card(CardColor.Red);
        }

        for (var index = ProgramConstants.HalfDeckSize; index < ProgramConstants.DeckSize; index++)
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