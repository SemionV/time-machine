using TimeMachine.Domain.Commands;
using TimeMachine.Domain.Entities;
using TimeMachine.Domain.Exceptions.Execution;
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
        Entity entityFrom = ReferenceResolver.Resolve(command.From, context.Memory.Heap);
        if(entityFrom == null)
            throw new InvalidEntityException();
        
        Entity entityTo = ReferenceResolver.Resolve(command.To, context.Memory.Stack.Peek());
        if(entityTo == null)
            throw new InvalidEntityException();
        
        
    }
}