namespace TimeMachine.Domain.Execution;

public interface ICommand
{
    public Instruction Instruction { get; }
}