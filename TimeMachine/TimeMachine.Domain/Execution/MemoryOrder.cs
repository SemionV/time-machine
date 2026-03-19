namespace TimeMachine.Domain.Execution;

public enum MemoryOrder
{
    Free,
    Relaxed,
    Acquire,
    Release,
    Strict
}