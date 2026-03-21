using TimeMachine.Domain.Entities;

namespace TimeMachine.Domain.TypeSystem;

public class FloatingPointType: ValueType
{
    public override EntityType EntityType => EntityType.FloatingPoint;
}