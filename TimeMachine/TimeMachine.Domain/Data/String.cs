namespace TimeMachine.Domain.Data;

public class String: IValue
{
    public ValueType Type => ValueType.String;
    
    public string Data { get; set; }
}