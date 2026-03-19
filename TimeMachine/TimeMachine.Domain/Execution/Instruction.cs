namespace TimeMachine.Domain.Execution;

public enum Instruction
{
    Return,
    Break,
    Continue,
    Write,
    Read
}