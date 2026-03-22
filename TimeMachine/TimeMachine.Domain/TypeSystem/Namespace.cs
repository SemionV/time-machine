namespace TimeMachine.Domain.TypeSystem;

public class Namespace
{
    public required string Name { get; set; }
    public required Namespace Parent { get; set; }
    public required List<Type> Types { get; set; }
}