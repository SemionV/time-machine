using TimeMachine.Domain.Commands;
using TimeMachine.Domain.Execution;

namespace ExecutionEngine;

public class Processor
{
    public virtual void Execute(ExecutionNode node, Memory memory)
    {
        var context = new RuntimeContext
        {
            Scope =  new Stack<Command>(),
            Memory = memory
        };
        
        
    }

    private ExecutionNode ProcessNode(ExecutionNode node, RuntimeContext context)
    {
        var command = node.Command;
        context.Scope.Push(command);
        
        ExecuteCommand(command, context);
        
        return node.Next;
    }

    private void ExecuteCommand(Command command, RuntimeContext context)
    {
        var instruction = command.Instruction;

        switch (instruction)
        {
            case Instruction.Read:
                ExecuteReadCommand(command as Read, context);
                break;
        }
    }
    
    private void ExecuteReadCommand(Read command, RuntimeContext context)
    {
        
    }
}