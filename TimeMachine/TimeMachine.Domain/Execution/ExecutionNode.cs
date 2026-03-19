namespace TimeMachine.Domain.Execution;

public class ExecutionNode
{
    public ExecutionNode Next { get; set; }
    public Command Command { get; set; }
}