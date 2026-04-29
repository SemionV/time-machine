using TimeMachine.Domain.References;

namespace TimeMachine.Domain.Exceptions.Logic.Predicates;

public class UnresolvedReference : Exception
{
    public CompoundReference Reference { get; }
    
    public UnresolvedReference(CompoundReference reference)
    {
        Reference = reference;
    }
}