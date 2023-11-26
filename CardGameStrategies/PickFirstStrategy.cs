using CardGameStrategies.interfaces;
using Cards.Card;

namespace CardGameStrategies;

public class PickFirstStrategy : ICardPickStrategy
{
    
    public int Pick(Card[] cards)
    {
        return 1;
    }
   
}