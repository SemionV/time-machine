namespace TimeMachine.Domain.Execution;

public enum Instruction
{
    Return,
    Break,
    Continue,
    Loop,
    Branch,
    Write,
    Read,
    Call
}