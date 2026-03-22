using TimeMachine.Domain.TypeSystem;

namespace TimeMachine.Domain.Entities;

public class Object: TypedEntity<ClassType>
{
    public Dictionary<string, Entity> Fields { get; }
    
    public Object(ClassType type) : base(type)
    {
        Fields = new Dictionary<string, Entity>();
    }
}