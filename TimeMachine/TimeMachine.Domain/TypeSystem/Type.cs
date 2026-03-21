using TimeMachine.Domain.Entities;

namespace TimeMachine.Domain.TypeSystem;

public abstract class Type
{
    public Namespace Namespace { get; set; }
    public string Name { get; set; }
    public abstract EntityType EntityType { get; }
}