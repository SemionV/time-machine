namespace TimeMachine.Domain.Data;

public class FloatingPoint: Value<float>
{
    public override ObjectType Type => ObjectType.FloatingPoint;
}