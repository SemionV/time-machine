using TimeMachine.Domain.Entities;
using TimeMachine.Domain.Predicates;

namespace TimeMachine.Domain.Exceptions.Logic.Predicates;

public class UnsupportedType : Exception
{
    public PredicateType PredicateType { get; private set; }
    public EntityType EntityType { get; private set; }

    public UnsupportedType(PredicateType predicateType, EntityType entityType)
    {
        PredicateType = predicateType;
        EntityType = entityType;
    }
}