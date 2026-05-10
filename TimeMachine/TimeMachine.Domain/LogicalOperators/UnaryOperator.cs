using TimeMachine.Domain.Predicates;
using TimeMachine.Domain.References;

namespace TimeMachine.Domain.LogicalOperators;

public class UnaryOperator: Operator
{
    public override LogicalOperatorType Type => LogicalOperatorType.Unary;
    public required CompoundReference Argument { get; set; }
}