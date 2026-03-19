using TimeMachine.Domain.Execution;
using TimeMachine.Domain.References;

namespace TimeMachine.Domain.Commands;

public class Call: Command
{
    public override Instruction Instruction => Instruction.Call;
    
    public required Reference Function { get; set; }
    public required Dictionary<string, Reference> Arguments { get; set; }
    public required Reference Result { get; set; }
}