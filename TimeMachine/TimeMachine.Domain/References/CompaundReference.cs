namespace TimeMachine.Domain.References;

public class CompoundReference
{
    public required IEnumerable<ObjectReference> Path { get; set; }
    public ValueReference ValueReference { get; set; }
}