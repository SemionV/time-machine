using TimeMachine.Domain.TypeSystem;
using Type = TimeMachine.Domain.TypeSystem.Type;

namespace TimeMachine.Domain.Entities;

public class FloatingPoint: Value<float, FloatingPointType>
{
    public FloatingPoint(FloatingPointType type):  base(type)
    {
    }
}