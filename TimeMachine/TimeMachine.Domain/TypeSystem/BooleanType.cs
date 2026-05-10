using TimeMachine.Domain.Entities;

namespace TimeMachine.Domain.TypeSystem;

public class BooleanType : ValueType
{
    public override EntityType EntityType => EntityType.Boolean;
}