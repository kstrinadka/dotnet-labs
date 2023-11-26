using CardGameStrategies.interfaces;
using Cards.Card;

namespace CardGameStrategies;

public class PickSecondStrategy : ICardPickStrategy
{
    
    public int Pick(Card[] cards)
    {
        return 1;
    }
   
}