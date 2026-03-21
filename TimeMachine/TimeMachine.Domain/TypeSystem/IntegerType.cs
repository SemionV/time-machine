using TimeMachine.Domain.Entities;

namespace TimeMachine.Domain.TypeSystem;

public class IntegerType: ValueType
{
    public override EntityType EntityType => EntityType.Integer;
}