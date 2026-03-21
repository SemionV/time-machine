using TimeMachine.Domain.Entities;

namespace TimeMachine.Domain.TypeSystem;

public class StringType: ValueType
{
    public override EntityType EntityType => EntityType.String;
}