namespace TimeMachine.Domain.Data;

public abstract class Value<TValue>: Entity
{
    public TValue Data { get; set; }
}