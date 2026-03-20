namespace TimeMachine.Domain.LogicalOperators;

public class OperatorNot: UnaryOperator
{
    public override LogicalOperatorType Type => LogicalOperatorType.Not;
}