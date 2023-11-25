namespace NsuLabs.Cards;

// колода карт
// умеет сама создавать себя и перемешивать
public class Deck
{
    // размер колоды
    private const int HalfDeckSize = 18;
    private const int DeckSize = 36;
    
    private Card[] _firstPartOfDeckDeck = new Card[HalfDeckSize];
    public Card[] FirstPartOfDeckDeck => _firstPartOfDeckDeck;

    private Card[] _secondPartOfDeck = new Card[HalfDeckSize];
    public Card[] SecondPartOfDeck => _secondPartOfDeck;

    private readonly Card[] _wholeDeck = new Card[DeckSize];
    public Card[] WholeDeck => _wholeDeck;

    public Deck()
    {
        FillWholeDeckAndShuffle();
        FillDeckHalfs();
    }
    
    // заполняем всю колоду из 18 красных и 18 черных карт
    private void FillWholeDeckAndShuffle()
    {
        for (var index = 0; index < HalfDeckSize; index++)
        {
            _wholeDeck[index] = new Card(CardColor.Red);
        }

        for (var index = HalfDeckSize; index < DeckSize; index++)
        {
            _wholeDeck[index] = new Card(CardColor.Black);
        }

        Shuffle(_wholeDeck);
    }
    
    // разбиваем колоду на 2 части
    private void FillDeckHalfs()
    {
        _firstPartOfDeckDeck = SubArray(_wholeDeck, 0, HalfDeckSize);
        _secondPartOfDeck = SubArray(_wholeDeck, HalfDeckSize, HalfDeckSize);
    }
    
    // Алгоритм для перемешивания колоды карт
    private T[] Shuffle<T> (T[] array)
    {
        Random rnd = new Random();
        int n = array.Length;
        while (n > 0) 
        {
            int k = rnd.Next(n--);
            (array[n], array[k]) = (array[k], array[n]);
        }
        return array;
    }
    
    private T[] SubArray<T>(T[] array, int index, int length)
    {
        T[] result = new T[length];
        Array.Copy(array, index, result, 0, length);
        return result;
    }
}