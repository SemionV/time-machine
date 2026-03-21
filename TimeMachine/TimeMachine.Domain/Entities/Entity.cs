using Type = TimeMachine.Domain.TypeSystem.Type;

namespace TimeMachine.Domain.Data;

public abstract class Entity
{
    public abstract Type Type { get; }
}