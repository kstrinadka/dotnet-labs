using Cards;
using Cards.Card;
using Cards.Shuffle;
using Deck = Cards.Deck;

namespace NsuLabs.Util;

public class WriteDecks
{
    
    // использовал для проверки того, как создается и перемешивается колода карт.
    public static void WriteAllDecks()
    {
        PrintNewDeck();
        PrintNewDeckAndShuffle();
        SufflerGetShuffledDeck();
    }


    // Проверяю как создается неперемешанная колода
    private static void PrintNewDeck()
    {

        Console.WriteLine("\n \n wihtout shuffling \n");
        var deck = new Deck();
        
        Console.WriteLine("WholeDeck: ");
        var deckWholeDeck = deck.WholeDeck;
        foreach (Card element in deckWholeDeck)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();


        Console.WriteLine("FirstPartOfDeckDeck: ");
        var deckFirstPartOfDeckDeck = deck.FirstPartOfDeck;
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
    
    // Перемешиваю колоду
    private static void PrintNewDeckAndShuffle()
    {

        Console.WriteLine("\n \n create and shuffle \n");
        var deck = new Deck();
        var deckShuffler = new DeckShuffler();
        deckShuffler.Shuffle(deck);

        Console.WriteLine("WholeDeck: ");
        var deckWholeDeck = deck.WholeDeck;
        foreach (Card element in deckWholeDeck)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();


        Console.WriteLine("FirstPartOfDeckDeck: ");
        var deckFirstPartOfDeckDeck = deck.FirstPartOfDeck;
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
    
    
    private static void SufflerGetShuffledDeck()
    {

        Console.WriteLine("\n \n shuffler get shuffled deck \n");
        var deckShuffler = new DeckShuffler();
        var deck = deckShuffler.GetNewShuffledDeck();
        deckShuffler.Shuffle(deck);

        Console.WriteLine("WholeDeck: ");
        var deckWholeDeck = deck.WholeDeck;
        foreach (Card element in deckWholeDeck)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();


        Console.WriteLine("FirstPartOfDeckDeck: ");
        var deckFirstPartOfDeckDeck = deck.FirstPartOfDeck;
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