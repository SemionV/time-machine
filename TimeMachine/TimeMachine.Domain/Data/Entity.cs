namespace TimeMachine.Domain.Data;

public abstract class Entity
{
    public abstract EntityType Type { get; }
}