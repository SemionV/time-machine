using TimeMachine.Domain.References;

namespace TimeMachine.Domain.Predicates;

public abstract class Predicate
{
    public abstract PredicateType Type { get; }
}