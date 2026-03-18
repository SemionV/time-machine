namespace TimeMachine.Domain.Data;

public class FloatingPoint: IValue
{
    public ValueType Type => ValueType.FloatingPoint;
    
    public float Data { get; set; }
}