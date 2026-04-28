namespace TimeMachine.Domain.Predicates;

public class NotEqual: Predicate
{
    public override PredicateType Type => PredicateType.NotEqual;
}