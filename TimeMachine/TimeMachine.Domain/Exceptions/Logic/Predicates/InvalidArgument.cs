using TimeMachine.Domain.Entities;
using TimeMachine.Domain.Predicates;

namespace TimeMachine.Domain.Exceptions.Logic.Predicates;

public class InvalidArgument: Exception
{
    public PredicateType PredicateType { get; private set; }
    public EntityType EntityTypeLeft { get; private set; }
    public EntityType EntityTypeRight { get; private set; }

    public InvalidArgument(PredicateType predicateType, EntityType leftType, EntityType rightType)
    {
        PredicateType = predicateType;
        EntityTypeLeft = leftType;
        EntityTypeRight = rightType;
    }
}