namespace TimeMachine.Domain.Data;

public class Object: IValue
{
    public ValueType Type => ValueType.Object;
    
    public required Dictionary<string, IValue> Properties { get; set; }
}