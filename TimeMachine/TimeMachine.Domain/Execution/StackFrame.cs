using TimeMachine.Domain.Data;

namespace TimeMachine.Domain.Execution;

public class StackFrame
{
    public required Dictionary<string, Entity> Variables { get; set; }
}