namespace TimeMachine.Domain.Execution;

public class Memory
{
    public required Stack<StackFrame> Stack { get; set; }
    public StackFrame Heap { get; set; }
}