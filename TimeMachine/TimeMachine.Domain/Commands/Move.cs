using TimeMachine.Domain.Execution;
using TimeMachine.Domain.References;

namespace TimeMachine.Domain.Commands;

public abstract class Move: Command
{
    public required Reference From { get; set; }
    public required Reference To { get; set; }
    public MemoryOrder MemoryOrder { get; set; }
}