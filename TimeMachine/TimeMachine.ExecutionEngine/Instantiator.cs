using TimeMachine.Domain.Entities;
using TimeMachine.Domain.TypeSystem;
using Array = TimeMachine.Domain.Entities.Array;
using Object = TimeMachine.Domain.Entities.Object;
using String = TimeMachine.Domain.Entities.String;

namespace ExecutionEngine;

public class Instantiator
{
    public static Entity Instantiate(TimeMachine.Domain.TypeSystem.Type type)
    {
        Entity entity = null;
        
        if (type.EntityType == EntityType.Array)
        {
            entity = new Array(type as ArrayType);
        }
        else if (type.EntityType == EntityType.Class)
        {
            var classType = type as ClassType;
            var obj = new Object(classType);

            foreach (var memberEntry in classType.Members)
            {
                var memberEntity = Instantiate(memberEntry.Value);
                obj.Fields.Add(memberEntry.Key, memberEntity);
            }
            
            entity = obj;
        }
        else if (type.EntityType == EntityType.FloatingPoint)
        {
            entity = new FloatingPoint(type as FloatingPointType);
        }
        else if (type.EntityType == EntityType.Integer)
        {
            entity = new Integer(type as IntegerType);
        }
        else if (type.EntityType == EntityType.String)
        {
            entity = new String(type as StringType);
        }
        else if (type.EntityType == EntityType.Function)
        {
            var functionType = type as FunctionType;
            entity = new Function(functionType);
        }
        else if (type.EntityType == EntityType.FunctionBinding)
        {
            var functionBindingType = type as FunctionBindingType;
            entity = new FunctionBinding(functionBindingType);
        }
        
        return entity;
    }
}