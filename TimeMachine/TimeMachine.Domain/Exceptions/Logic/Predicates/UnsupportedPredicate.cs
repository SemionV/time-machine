using TimeMachine.Domain.Predicates;

namespace TimeMachine.Domain.Exceptions.Logic.Predicates;

public class UnsupportedPredicate : Exception
{
    public Predicate Predicate { get; }
    
    public UnsupportedPredicate(Predicate predicate)
    {
        Predicate = predicate;
    }
}