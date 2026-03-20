using TimeMachine.Domain.Predicates;

namespace TimeMachine.Domain.LogicalOperators;

public abstract class Operator
{
    public abstract LogicalOperatorType Type { get; }
}