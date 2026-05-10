using TimeMachine.Domain.TypeSystem;

namespace TimeMachine.Domain.Entities;

public class Boolean : Value<bool, BooleanType>
{
    public Boolean(BooleanType type) : base(type)
    {
    }
}