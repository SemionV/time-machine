using TimeMachine.Domain.References;

namespace TimeMachine.Domain.Commands;

public class Move
{
    public required CompoundReference From { get; set; }
    public required CompoundReference To { get; set; }
    public MemoryOrder MemoryOrder { get; set; }
}