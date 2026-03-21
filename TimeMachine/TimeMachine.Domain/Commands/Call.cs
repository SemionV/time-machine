using TimeMachine.Domain.Execution;
using TimeMachine.Domain.References;

namespace TimeMachine.Domain.Commands;

public class Call: Command
{
    public override Instruction Instruction => Instruction.Call;
    
    public required CompoundReference Function { get; set; }
    public required Dictionary<string, CompoundReference> Arguments { get; set; }
    public required CompoundReference Result { get; set; }
}