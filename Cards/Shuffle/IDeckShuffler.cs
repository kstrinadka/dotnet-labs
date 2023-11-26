namespace Cards.Shuffle;

public interface IDeckShuffler
{
    // Перемешивает уже существующую колоду.
    Deck Shuffle (Deck deck);
    
    // создает новую колоду, перемешивает ее и возвращает.
    Deck GetNewShuffledDeck();
}