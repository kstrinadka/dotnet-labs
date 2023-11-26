using CardGameStrategies.interfaces;
using Cards.Card;

namespace CardGameStrategies;

public class PickFirstStrategy : ICardPickStrategy
{
    
    public static int GetCardNumber(Card[] cards)
    {
        return new PickFirstStrategy().Pick(cards);
    }
    
    public int Pick(Card[] cards)
    {
        return 1;
    }
   
}