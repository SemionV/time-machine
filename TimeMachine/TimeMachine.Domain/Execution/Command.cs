namespace TimeMachine.Domain.Execution;

public abstract class Command
{
    public abstract Instruction Instruction { get; }
}