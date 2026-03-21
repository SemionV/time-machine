namespace TimeMachine.Domain.Data;

public class Array: Entity
{
    public override EntityType Type => EntityType.Array;
    public required List<Entity> Items { get; set; }
}