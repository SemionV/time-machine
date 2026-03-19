using TimeMachine.Domain.Execution;

namespace TimeMachine.Domain.Data;

public class Function: Entity
{
    public override EntityType Type => EntityType.Function;
    public required ExecutionNode ExecutionNode { get; set; }
}