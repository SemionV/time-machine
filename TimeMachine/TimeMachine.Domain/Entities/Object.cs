using TimeMachine.Domain.TypeSystem;

namespace TimeMachine.Domain.Entities;

public class Object: TypedEntity<Classtype>
{
    public required Dictionary<string, Entity> Fields { get; set; }
    
    public Object(Classtype type, Dictionary<string, Entity> fields) : base(type)
    {
        Fields = fields;
    }
}