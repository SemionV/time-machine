using TimeMachine.Domain.TypeSystem;
using Type = TimeMachine.Domain.TypeSystem.Type;

namespace TimeMachine.Domain.Data;

public class Object: Entity
{
    private readonly Class _classType;
    public override Type Type => _classType;
    public required Dictionary<string, Entity> Fields { get; set; }
    
    public Object(Class type, Dictionary<string, Entity> fields)
    {
        _classType = type;
        Fields = fields;
    }
}