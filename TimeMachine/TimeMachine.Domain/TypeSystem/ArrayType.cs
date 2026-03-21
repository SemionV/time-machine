using TimeMachine.Domain.Entities;

namespace TimeMachine.Domain.TypeSystem;

public class ArrayType: Type
{
    public override EntityType EntityType => EntityType.Array;
    public Type ItemsType { get; set; }
    public int Length { get; set; }
}