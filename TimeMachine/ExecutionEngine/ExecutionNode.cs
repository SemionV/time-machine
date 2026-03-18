namespace ExecutionEngine;

public class ExecutionNode
{
    public ExecutionNode Next { get; set; }
    public Command Command { get; set; }
}