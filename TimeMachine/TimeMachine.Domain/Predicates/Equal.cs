namespace TimeMachine.Domain.Predicates;

public class Equal: Binary
{
    public override PredicateType Type => PredicateType.Equal;
}