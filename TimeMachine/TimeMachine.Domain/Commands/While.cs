using TimeMachine.Domain.Execution;

namespace TimeMachine.Domain.Commands;

public class While: Loop
{
    public override Instruction Instruction => Instruction.While;
}