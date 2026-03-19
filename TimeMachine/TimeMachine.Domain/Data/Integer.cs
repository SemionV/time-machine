namespace TimeMachine.Domain.Data;

public class Integer: Value<long>
{
    public override EntityType Type => EntityType.Integer;
}