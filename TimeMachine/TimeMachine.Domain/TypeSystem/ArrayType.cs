using TimeMachine.Domain.Entities;

namespace TimeMachine.Domain.TypeSystem;

public class ArrayType: Type
{
    public override EntityType EntityType => EntityType.Array;
    public Type ElementType { get; }
    public int Length { get; }

    public ArrayType(Type elementType, int length)
    {
        ElementType = elementType;
        Length = length;
    }
}