namespace TimeMachine.Domain.Predicates;

public class GreaterThan: Binary
{
    public override PredicateType Type => PredicateType.GreaterThan;
}