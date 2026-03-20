namespace TimeMachine.Domain.Predicates;

public class LessThan: Binary
{
    public override PredicateType Type => PredicateType.LessThan;
}