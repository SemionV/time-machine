using TimeMachine.Domain.TypeSystem;
using Type = TimeMachine.Domain.TypeSystem.Type;

namespace TimeMachine.Domain.Entities;

public class Array: TypedEntity<ArrayType>
{
    public required List<Entity> Items { get; set; }

    public Array(ArrayType arrayType): base(arrayType)
    {
    }
}