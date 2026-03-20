namespace TimeMachine.Domain.Predicates;

public class LessThanOrEqual: Binary
{
    public override PredicateType Type => PredicateType.LessThanOrEqual;
}