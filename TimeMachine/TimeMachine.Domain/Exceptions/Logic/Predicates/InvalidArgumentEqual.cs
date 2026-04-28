using TimeMachine.Domain.Entities;

namespace TimeMachine.Domain.Exceptions.Logic.Predicates;

public class InvalidArgumentEqual: Exception
{
    public EntityType EntityTypeLeft { get; private set; }
    public EntityType EntityTypeRight { get; private set; }

    public InvalidArgumentEqual(EntityType leftType, EntityType rightType)
    {
        EntityTypeLeft = leftType;
        EntityTypeRight = rightType;
    }
}