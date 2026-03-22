namespace TimeMachine.Domain.Exceptions.TypeSystem;
using Type = TimeMachine.Domain.TypeSystem.Type;

public class ArrayInvalidEntityTypeException: Exception
{
    public Type ElementType { get; set; }
    public Type EntityType { get; set; }
    
    public ArrayInvalidEntityTypeException(Type elementType, Type entityType)
    {
        ElementType = elementType;
        EntityType = entityType;
    }
}