using TimeMachine.Domain.Entities;

namespace TimeMachine.Domain.TypeSystem;

public class ClassType: Type
{
    public override EntityType EntityType => EntityType.Object;
    public Dictionary<string, Type> Members { get; set; }
}