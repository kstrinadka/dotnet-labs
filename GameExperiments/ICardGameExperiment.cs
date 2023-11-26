using CardGameStrategies.interfaces;

namespace GameExperiments;

public interface ICardGameExperiment
{
    bool RunExperiment(ICardPickStrategy elonStrategy, ICardPickStrategy markStrategy);
}