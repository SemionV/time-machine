namespace TimeMachine.Domain;

public enum MemoryOrder
{
    Free,
    Relaxed,
    Acquire,
    Release,
    Strict
}