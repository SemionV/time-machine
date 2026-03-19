using TimeMachine.Domain.Execution;
using TimeMachine.Domain.References;

namespace TimeMachine.Domain.Commands;

public abstract class Move: ICommand
{
    public abstract Instruction Instruction { get; }
    
    public required CompoundReference From { get; set; }
    public required CompoundReference To { get; set; }
    public MemoryOrder MemoryOrder { get; set; }
}