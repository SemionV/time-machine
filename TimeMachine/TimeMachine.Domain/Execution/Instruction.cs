namespace TimeMachine.Domain.Execution;

public enum Instruction
{
    Return,
    Break,
    Continue,
    While,
    DoWhile,
    For,
    Branch,
    Write,
    Read,
    Call
}