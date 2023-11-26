namespace Cards.Shuffle;


// Создает колоду, перемешивает ее и возвращает
public class DeckShuffler: IDeckShuffler
{
    
    public Deck GetNewShuffledDeck()
    {
        var deck = new Deck();
        return Shuffle(deck);
    }
    
    public Deck Shuffle (Deck deck)
    {
        Random rnd = new Random();
        Card.Card[] allCardsOfDeck = deck.WholeDeck;
        int n = allCardsOfDeck.Length;
        while (n > 0) 
        {
            int k = rnd.Next(n--);
            // (allCardsOfDeck[n], allCardsOfDeck[k]) = (allCardsOfDeck[k], allCardsOfDeck[n]);
            deck.SwapCards(n,k);
        }

        return deck;
    }

}