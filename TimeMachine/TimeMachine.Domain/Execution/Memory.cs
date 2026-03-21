using Object = TimeMachine.Domain.Entities.Object;

namespace TimeMachine.Domain.Execution;

public class Memory
{
    public required Stack<Object> Stack { get; set; }
    public Object Heap { get; set; }
}