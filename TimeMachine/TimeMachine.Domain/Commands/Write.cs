using TimeMachine.Domain.Execution;

namespace TimeMachine.Domain.Commands;

public class Write: Move
{
    public override Instruction Instruction => Instruction.Write;
}