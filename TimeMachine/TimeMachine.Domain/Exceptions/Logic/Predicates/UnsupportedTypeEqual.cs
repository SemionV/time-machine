using TimeMachine.Domain.Entities;

namespace TimeMachine.Domain.Exceptions.Logic.Predicates;

public class UnsupportedTypeEqual : Exception
{
    public EntityType EntityType { get; private set; }

    public UnsupportedTypeEqual(EntityType entityType)
    {
        EntityType = entityType;
    }
}