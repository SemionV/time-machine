namespace ExecutionEngine;

public abstract class Command
{
    public abstract void Run(RuntimeContext context);
}