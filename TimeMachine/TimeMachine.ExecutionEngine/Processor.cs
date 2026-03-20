using TimeMachine.Domain.Commands;
using TimeMachine.Domain.Data;
using TimeMachine.Domain.Execution;
using TimeMachine.Domain.References;

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

    private Entity GetEntity(Reference reference, StackFrame frame)
    {
        Entity container =  null;
        if (reference.Path != null)
        {
            foreach (var objectReference in reference.Path)
            {
                Entity entity = null;

                if (objectReference is ObjectReference)
                {
                    if (container == null)
                    {
                        frame.Variables.TryGetValue(objectReference.Key, out entity);
                    }
                    else
                    {
                        if()
                    }
                }
            }
        }
    }
}