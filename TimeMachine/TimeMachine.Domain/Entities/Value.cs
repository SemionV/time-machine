using Type = TimeMachine.Domain.TypeSystem.Type;

namespace TimeMachine.Domain.Entities;

public abstract class Value<TValue, TType>: TypedEntity<TType>
    where TType : Type
{
    public required TValue Data { get; set; }

    protected Value(TType type) : base(type)
    {
    }
}