namespace TimeMachine.Domain.Data;

public class String: Value<string>
{
    public override EntityType Type => EntityType.String;
}