namespace TimeMachine.Domain.Data;

public class Object: Entity
{
    public override EntityType Type => EntityType.Object;
    public required Dictionary<string, Entity> Properties { get; set; }
}