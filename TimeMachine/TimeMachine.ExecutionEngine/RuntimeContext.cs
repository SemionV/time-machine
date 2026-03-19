using TimeMachine.Domain.Execution;

namespace ExecutionEngine;

public class RuntimeContext
{
    public required Stack<ExecutionNode> Scope { get; set; }
}