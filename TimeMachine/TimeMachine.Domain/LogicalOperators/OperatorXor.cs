namespace TimeMachine.Domain.LogicalOperators;

public class OperatorXor: BinaryOperator
{
    public override LogicalOperatorType Type => LogicalOperatorType.Xor;
}