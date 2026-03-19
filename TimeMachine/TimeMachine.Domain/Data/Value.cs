using TimeMachine.Domain.References;

namespace TimeMachine.Domain.Data;

public abstract class Value<TValue>: IValue<TValue>
{
    private TValue _value;
    
    public abstract ObjectType Type { get; }

    public void Write(TValue value, CompoundReference from, CompoundReference to)
    {
        _value = value;
    }

    public TValue Read(CompoundReference from, CompoundReference to)
    {
        return _value;
    }
}