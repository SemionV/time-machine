using TimeMachine.Domain.Execution;

namespace TimeMachine.Domain.Commands;

public class Variable: Command
{
    public override Instruction Instruction => Instruction.Variable;
    //TODO: variable Key
    //TODO: variable Type
    //TODO: variable Container
}