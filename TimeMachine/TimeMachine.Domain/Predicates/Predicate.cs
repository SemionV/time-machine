using TimeMachine.Domain.References;

namespace TimeMachine.Domain.Predicates;

public abstract class Predicate
{
    public abstract PredicateType Type { get; }
    public CompoundReference Left { get; set; }
    public CompoundReference Right { get; set; }
}