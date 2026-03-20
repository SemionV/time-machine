namespace TimeMachine.Domain.LogicalOperators;

public class OperatorAnd: BinaryOperator
{
    public override LogicalOperatorType Type => LogicalOperatorType.And;
}