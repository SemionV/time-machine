namespace TimeMachine.Domain.LogicalOperators;

public class OperatorOr: BinaryOperator
{
    public override LogicalOperatorType Type => LogicalOperatorType.Or;
}