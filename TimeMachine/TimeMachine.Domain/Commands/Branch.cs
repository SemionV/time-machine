using TimeMachine.Domain.Execution;

namespace TimeMachine.Domain.Commands;

public class Branch: Command
{
    public override Instruction Instruction => Instruction.Branch;
}