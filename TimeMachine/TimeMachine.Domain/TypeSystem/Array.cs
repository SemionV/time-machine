using TimeMachine.Domain.Data;

namespace TimeMachine.Domain.TypeSystem;

public class Array: Type
{
    public override EntityType EntityType => EntityType.Array;
    public Type ItemsType { get; set; }
    public int Length { get; set; }
}