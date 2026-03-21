using Type = TimeMachine.Domain.TypeSystem.Type;

namespace TimeMachine.Domain.Entities;

public abstract class Entity
{
    public abstract Type Type { get; }
}

public class TypedEntity<TType>: Entity
    where TType : Type
{
    private readonly TType _type;

    public override Type Type => _type;

    protected TypedEntity(TType type)
    {
        _type = type;
    }
}