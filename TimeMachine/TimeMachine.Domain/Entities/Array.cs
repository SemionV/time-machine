using TimeMachine.Domain.Exceptions.TypeSystem;
using TimeMachine.Domain.TypeSystem;

namespace TimeMachine.Domain.Entities;

public class Array: TypedEntity<ArrayType>
{
    public Entity[] Elements { get; }
    public int Length { get; }

    public Array(ArrayType arrayType): base(arrayType)
    {
        Elements = new Entity[arrayType.Length];
        Length = arrayType.Length;
    }
    
    public Entity this[int i]
    {
        get => Elements[i];
        set
        {
            if(value.Type != _type)
                throw new ArrayInvalidEntityTypeException(_type, value.Type);
            
            Elements[i] = value;
        }
    }
}