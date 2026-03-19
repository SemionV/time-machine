using TimeMachine.Domain.Execution;

namespace TimeMachine.Domain.Commands;

public class Loop: Command
{
    public override Instruction Instruction => Instruction.Loop;
}