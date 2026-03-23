using TimeMachine.Domain.Entities;
using TimeMachine.Domain.Exceptions.TypeSystem;
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

    public static void Copy(Entity source, Entity target)
    {
        var sourceType = source.Type;
        var targetType = target.Type;
        
        if (sourceType != targetType)
            throw new OnCopyTypeMismatchException(sourceType, targetType);


        if (sourceType.EntityType == EntityType.Array)
        {
            var sourceArray = source as Array;
            var targetArray = target as Array;
            
            for (var i = 0; i < sourceArray.Length; ++i)
            {
                Copy(sourceArray[i], targetArray[i]);
            }
        }
        else if (sourceType.EntityType == EntityType.Class)
        {
            var sourceObject = source as Object;
            var targetObject = target as Object;

            foreach (var sourceField in sourceObject.Fields)
            {
                Copy(sourceField.Value, targetObject.Fields[sourceField.Key]);
            }
        }
        else if (sourceType.EntityType == EntityType.FloatingPoint)
        {
            var sourceFloatingPoint = source as FloatingPoint;
            var targetFloatingPoint = target as FloatingPoint;
            
            targetFloatingPoint.Data = sourceFloatingPoint.Data;
        }
        else if (sourceType.EntityType == EntityType.Integer)
        {
            var sourceInteger = source as Integer;
            var targetInteger = target as Integer;
            
            targetInteger.Data = sourceInteger.Data;
        }
        else if (sourceType.EntityType == EntityType.String)
        {
            var sourceString = source as String;
            var targetString = target as String;
            
            targetString.Data = sourceString.Data;
        }
        else if (sourceType.EntityType == EntityType.Function)
        {
            //Nothing to copy yet, maybe execution state later
        }
        else if (sourceType.EntityType == EntityType.FunctionBinding)
        {
            //Nothing to copy yet, maybe execution state later
        }
    }
}