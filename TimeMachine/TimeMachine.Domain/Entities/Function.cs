using TimeMachine.Domain.Execution;
using TimeMachine.Domain.TypeSystem;

namespace TimeMachine.Domain.Entities;

public class Function: TypedEntity<FunctionType>
{
    public ExecutionNode FunctionBody { get; }

    public Function(FunctionType type) : base(type)
    {
        FunctionBody = type.FunctionBody;
    }
}