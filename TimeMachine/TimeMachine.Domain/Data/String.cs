namespace TimeMachine.Domain.Data;

public class String: Value<string>
{
    public override ObjectType Type => ObjectType.String;
}