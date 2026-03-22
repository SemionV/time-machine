using TimeMachine.Domain.Entities;
using TimeMachine.Domain.Execution;

namespace TimeMachine.Domain.TypeSystem;

public class FunctionType: CallableType
{
    public override EntityType EntityType => EntityType.Function;
    public ExecutionNode FunctionBody { get; }

    public FunctionType(ExecutionNode functionBody)
    {
        FunctionBody = functionBody;
    }
}