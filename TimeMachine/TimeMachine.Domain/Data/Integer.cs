namespace TimeMachine.Domain.Data;

public class Integer: Value<long>
{
    public override ObjectType Type => ObjectType.Integer;
}