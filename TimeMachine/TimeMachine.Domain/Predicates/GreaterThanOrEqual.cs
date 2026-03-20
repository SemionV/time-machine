namespace TimeMachine.Domain.Predicates;

public class GreaterThanOrEqual: Binary
{
    public override PredicateType Type => PredicateType.GreaterThanOrEqual;
}