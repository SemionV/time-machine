using TimeMachine.Domain.TypeSystem;

namespace TimeMachine.Domain.Entities;

public class String: Value<string, StringType>
{
    public String(StringType type) : base(type)
    {
    }
}