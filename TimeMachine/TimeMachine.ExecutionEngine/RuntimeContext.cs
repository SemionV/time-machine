using TimeMachine.Domain.Execution;

namespace ExecutionEngine;

public class RuntimeContext
{
    public required Stack<Command> Scope { get; set; }
    public required Memory Memory { get; set; }
}