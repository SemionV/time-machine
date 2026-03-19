namespace TimeMachine.Domain.Execution;

public class StackFrame
{
    public required Dictionary<string, Object> Variables { get; set; }
}