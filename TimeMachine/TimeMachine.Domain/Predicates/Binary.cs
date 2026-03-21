using TimeMachine.Domain.References;

namespace TimeMachine.Domain.Predicates;

public abstract class Binary: Predicate
{
    public CompoundReference Left { get; set; }
    public CompoundReference Right { get; set; }
}