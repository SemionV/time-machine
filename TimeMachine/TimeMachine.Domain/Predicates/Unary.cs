using TimeMachine.Domain.References;

namespace TimeMachine.Domain.Predicates;

public class Unary: Predicate
{
    public override PredicateType Type => PredicateType.Unary;
    public required Reference Reference { get; set; }
}