using TimeMachine.Domain.Entities;

namespace TimeMachine.Domain.TypeSystem;

public class Classtype: Type
{
    public override EntityType EntityType => EntityType.Class;
    public Dictionary<string, Type> Members { get; set; }
    public Dictionary<string, Entity> InitializationValues { get; set; }
}