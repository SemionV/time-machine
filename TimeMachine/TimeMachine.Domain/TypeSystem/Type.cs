using TimeMachine.Domain.Data;

namespace TimeMachine.Domain.TypeSystem;

public abstract class Type
{
    public Namespace Namespace { get; set; }
    public string Name { get; set; }
    public abstract EntityType EntityType { get; }
}