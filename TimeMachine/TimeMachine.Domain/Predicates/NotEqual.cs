namespace TimeMachine.Domain.Predicates;

public class NotEqual: Binary
{
    public override PredicateType Type => PredicateType.NotEqual;
}