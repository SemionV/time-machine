using TimeMachine.Domain.Entities;
using TimeMachine.Domain.LogicalOperators;

namespace TimeMachine.Domain.Exceptions.Logic.Propositions;

public class InvalidUnaryArgument : Exception
{
    public LogicalOperatorType OperatorType { get; private set; }
    public Entity Entity { get; private set; }

    public InvalidUnaryArgument(LogicalOperatorType operatorType, Entity entity)
    {
        OperatorType = operatorType;
        Entity = entity;
    }
}