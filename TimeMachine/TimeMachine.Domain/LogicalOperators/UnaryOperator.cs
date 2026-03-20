using TimeMachine.Domain.Predicates;

namespace TimeMachine.Domain.LogicalOperators;

public class UnaryOperator: Operator
{
    public override LogicalOperatorType Type => LogicalOperatorType.Unary;
    public required Operator Argument { get; set; }
}