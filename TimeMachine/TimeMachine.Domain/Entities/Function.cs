using TimeMachine.Domain.Execution;
using TimeMachine.Domain.TypeSystem;

namespace TimeMachine.Domain.Entities;

public class Function: TypedEntity<FunctionType>
{
    public required ExecutionNode ExecutionNode { get; set; }

    public Function(FunctionType type) : base(type)
    {
    }
}