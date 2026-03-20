namespace TimeMachine.Domain.LogicalOperators;

public abstract class BinaryOperator: Operator
{
    public Operator Left { get; set; }
    public Operator Right { get; set; }
}