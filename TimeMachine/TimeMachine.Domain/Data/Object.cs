namespace TimeMachine.Domain.Data;

public class Object: IObject
{
    public ObjectType Type => ObjectType.Object;
    
    public required Dictionary<string, IObject> Properties { get; set; }
}