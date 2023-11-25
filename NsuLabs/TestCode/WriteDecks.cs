using NsuLabs.Cards;

namespace NsuLabs.TestCode;

public class WriteDecks
{
    
    // использовал для проверки того, как создается и перемешивается колода карт.
    public static void WriteAllDecks()
    {
        var deck = new Deck();


        Console.WriteLine("WholeDeck: ");
        var deckWholeDeck = deck.WholeDeck;
        foreach (Card element in deckWholeDeck)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();


        Console.WriteLine("FirstPartOfDeckDeck: ");
        var deckFirstPartOfDeckDeck = deck.FirstPartOfDeckDeck;
        foreach (Card element in deckFirstPartOfDeckDeck)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();

        Console.WriteLine("SecondPartOfDeck: ");
        var secondPartOfDeck = deck.SecondPartOfDeck;
        foreach (Card el in secondPartOfDeck)
        {
            Console.Write($"{el} ");
        }
        Console.WriteLine();

    } 
}