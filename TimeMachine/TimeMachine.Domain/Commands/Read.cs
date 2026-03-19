using TimeMachine.Domain.Execution;

namespace TimeMachine.Domain.Commands;

public class Read: Move
{
    public override Instruction Instruction => Instruction.Read;
}