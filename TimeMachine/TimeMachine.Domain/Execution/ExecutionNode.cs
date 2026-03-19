namespace TimeMachine.Domain.Execution;

public class ExecutionNode
{
    public ExecutionNode Next { get; set; }
    public ICommand Command { get; set; }
}