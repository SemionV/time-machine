namespace TimeMachine.Domain.Predicates;

public class Equal: Predicate
{
    public override PredicateType Type => PredicateType.Equal;
}