namespace TimeMachine.Domain.Execution;

public class Memory
{
    public required Stack<Data.Object> Stack { get; set; }
    public Data.Object Heap { get; set; }
}