namespace TimeMachine.Domain.Data;

public class FloatingPoint: Value<float>
{
    public override EntityType Type => EntityType.FloatingPoint;
}