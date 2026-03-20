using TimeMachine.Domain.References;

namespace TimeMachine.Domain.Predicates;

public abstract class Binary: Predicate
{
    public Reference Left { get; set; }
    public Reference Right { get; set; }
}