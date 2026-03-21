namespace TimeMachine.Domain.TypeSystem;

public class Namespace
{
    public string Name { get; set; }
    public Namespace Parent { get; set; }
}