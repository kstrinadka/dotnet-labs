using Cards;
using Cards.Card;

namespace NsuLabs.data;

public class ExperimentCondition
{
    public ExperimentCondition(string deckOrder)
    {
        DeckOrder = deckOrder;
    }
    
    public ExperimentCondition(Deck deck)
    {
        DeckOrder = "";
        foreach (var card in deck.WholeDeck)
        {
            if (card.Color.Equals(CardColor.Black))
            {
                DeckOrder += "B";
            }
            else
            {
                DeckOrder += "R";
            }
        }
    }

    public int Id { get; set; }
    public string DeckOrder { get; set; }
}