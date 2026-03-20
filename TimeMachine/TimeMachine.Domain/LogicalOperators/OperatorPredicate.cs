using TimeMachine.Domain.Predicates;

namespace TimeMachine.Domain.LogicalOperators;

public class OperatorPredicate: Operator
{
    public override LogicalOperatorType Type => LogicalOperatorType.Predicate;
    public required Predicate Predicate { get; set; }
}