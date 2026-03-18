namespace ExecutionEngine;

public class Memory
{
    public required Stack<Object> Stack { get; set; }
    public Object Heap { get; set; }
}