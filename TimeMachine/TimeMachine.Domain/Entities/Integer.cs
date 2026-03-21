using TimeMachine.Domain.TypeSystem;

namespace TimeMachine.Domain.Entities;

public class Integer: Value<long, IntegerType>
{
    public Integer(IntegerType type) : base(type)
    {
    }
}