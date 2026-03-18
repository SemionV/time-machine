namespace TimeMachine.Domain.Data;

public class Integer: IValue
{
    public ValueType Type => ValueType.Integer;

    public long Data { get; set; }
}