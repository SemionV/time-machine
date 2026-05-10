using TimeMachine.Domain.Entities;
using TimeMachine.Domain.Exceptions.Logic.Predicates;
using TimeMachine.Domain.Exceptions.Logic.Propositions;
using TimeMachine.Domain.LogicalOperators;
using TimeMachine.Domain.Predicates;
using Array = TimeMachine.Domain.Entities.Array;
using Boolean = TimeMachine.Domain.Entities.Boolean;
using Object = TimeMachine.Domain.Entities.Object;
using String = TimeMachine.Domain.Entities.String;

namespace ExecutionEngine;

public class LogicProcessor
{
    public static bool Process(Operator op, RuntimeContext context)
    {
        if (op.Type == LogicalOperatorType.Unary)
        {
            var unaryOperator = op as UnaryOperator;
            
            var entity = ReferenceResolver.Resolve(unaryOperator.Argument, context.Memory.Stack.Peek());
            if(entity == null)
                throw new UnresolvedReference(unaryOperator.Argument);
            
            if (entity.Type.EntityType == EntityType.Boolean)
            {
                return (entity as Boolean).Data;
            }

            if (entity.Type.EntityType == EntityType.Integer)
            {
                return (entity as Integer).Data != 0;
            }
            
            if (entity.Type.EntityType == EntityType.FloatingPoint)
            {
                return (entity as FloatingPoint).Data != 0.0f;
            }

            throw new InvalidUnaryArgument(LogicalOperatorType.Unary, entity);
        }
        
        if (op.Type == LogicalOperatorType.And)
        {
            return ProcessOperator(op as BinaryOperator, context, (l, r) => l && r);
        }
        
        if (op.Type == LogicalOperatorType.Predicate)
        {
            return Process((op as OperatorPredicate).Predicate, context);
        }

        return false;
    }

    private static bool ProcessOperator(BinaryOperator? op, RuntimeContext context, Func<bool, bool, bool> proposition)
    {
        if(op == null)
            throw new ArgumentException();
        var leftTruth = Process(op.Left, context);
        var rightTruth = Process(op.Right, context);
        return proposition(leftTruth, rightTruth);
    }

    public static bool Process(Predicate predicate, RuntimeContext context)
    {
        var leftEntity = ReferenceResolver.Resolve(predicate.Left, context.Memory.Stack.Peek());
        if(leftEntity == null)
            throw new UnresolvedReference(predicate.Left);
        var rightEntity = ReferenceResolver.Resolve(predicate.Right, context.Memory.Stack.Peek());
        if(rightEntity == null)
            throw new UnresolvedReference(predicate.Right);
        
        if(predicate.Type == PredicateType.Equal)
            return PredicateEqual(leftEntity, rightEntity);
        if(predicate.Type == PredicateType.NotEqual)
            return PredicateNotEqual(leftEntity, rightEntity);
        if(predicate.Type == PredicateType.LessThan)
            return PredicateLessThan(leftEntity, rightEntity);
        if(predicate.Type == PredicateType.LessThanOrEqual)
            return PredicateLessThanOrEqual(leftEntity, rightEntity);
        if(predicate.Type == PredicateType.GreaterThan)
            return PredicateGreaterThan(leftEntity, rightEntity);
        if(predicate.Type == PredicateType.GreaterThanOrEqual)
            return PredicateGreaterThanOrEqual(leftEntity, rightEntity);
        
        throw new UnsupportedPredicate(predicate);
    }

    private static bool PredicateEqual(Entity left, Entity right)
    {
        if (left.Type.EntityType == EntityType.Integer)
        {
            var leftInteger = (Integer) left;
            
            if (right.Type.EntityType == EntityType.Integer)
            {
                return leftInteger.Data == (right as Integer).Data;
            }

            if (right.Type.EntityType == EntityType.FloatingPoint)
            {
                return leftInteger.Data == (right as FloatingPoint).Data;
            }

            throw new InvalidArgument(PredicateType.Equal, left.Type.EntityType, right.Type.EntityType);
        }
        
        if (left.Type.EntityType == EntityType.FloatingPoint)
        {
            var leftFloat = (FloatingPoint) left;
            
            if (right.Type.EntityType == EntityType.FloatingPoint)
            {
                return leftFloat.Data == (right as FloatingPoint).Data;
            }

            if (right.Type.EntityType == EntityType.Integer)
            {
                return leftFloat.Data == (right as Integer).Data;
            }

            throw new InvalidArgument(PredicateType.Equal, left.Type.EntityType, right.Type.EntityType);
        }

        if (left.Type.EntityType == EntityType.String)
        {
            var leftString = (String) left;

            if (right.Type.EntityType == EntityType.String)
            {
                return leftString.Data == (right as String).Data;
            }
            
            throw new InvalidArgument(PredicateType.Equal, left.Type.EntityType, right.Type.EntityType);
        }

        if (left.Type.EntityType == EntityType.Array)
        {
            var leftArray = (Array) left;

            if (right.Type.EntityType == EntityType.Array)
            {
                var rightArray = (Array) right;
                
                if(leftArray.Length != rightArray.Length)
                    return false;

                for(var i = 0; i < leftArray.Length; i++)
                {
                    var leftItem =  leftArray[i];
                    var rightItem =  rightArray[i];
                    
                    if(!PredicateEqual(leftItem, rightItem))
                        return false;
                }
            }
            
            throw new InvalidArgument(PredicateType.Equal, left.Type.EntityType, right.Type.EntityType);
        }
        
        if (left.Type.EntityType == EntityType.Object)
        {
            var leftObject = (Object) left;

            if (right.Type.EntityType == EntityType.Object)
            {
                var rightObject = (Object) right;

                foreach (var leftField in leftObject.Fields)
                {
                    if (!rightObject.Fields.TryGetValue(leftField.Key, out var rightFieldValue))
                        return false;

                    if (!PredicateEqual(leftField.Value, rightFieldValue))
                        return false;
                }
            }
            
            throw new InvalidArgument(PredicateType.Equal, left.Type.EntityType, right.Type.EntityType);
        }

        if (left.Type.EntityType == EntityType.Function)
        {
            var leftFunction = (Function) left;
            
            if(right.Type.EntityType == EntityType.Function)
            {
                var rightFunction = (Function) right;
                
                return leftFunction.FunctionBody == rightFunction.FunctionBody;
            }
            
            throw new InvalidArgument(PredicateType.Equal, left.Type.EntityType, right.Type.EntityType);
        }
        
        if (left.Type.EntityType == EntityType.FunctionBinding)
        {
            var leftFunction = (FunctionBinding) left;
            
            if(right.Type.EntityType == EntityType.FunctionBinding)
            {
                var rightFunction = (FunctionBinding) right;
                
                return leftFunction.Callback == rightFunction.Callback;
            }
            
            throw new InvalidArgument(PredicateType.Equal, left.Type.EntityType, right.Type.EntityType);
        }

        throw new UnsupportedType(PredicateType.Equal, left.Type.EntityType);
    }

    private static bool PredicateNotEqual(Entity left, Entity right)
    {
        return !PredicateEqual(left, right);
    }

    private static bool PredicateGreaterThan(Entity left, Entity right)
    {
        if (left.Type.EntityType == EntityType.Integer)
        {
            var leftInteger = (Integer) left;
            
            if (right.Type.EntityType == EntityType.Integer)
            {
                return leftInteger.Data > (right as Integer).Data;
            }

            if (right.Type.EntityType == EntityType.FloatingPoint)
            {
                return leftInteger.Data > (right as FloatingPoint).Data;
            }

            throw new InvalidArgument(PredicateType.GreaterThan, left.Type.EntityType, right.Type.EntityType);
        }
        
        if (left.Type.EntityType == EntityType.FloatingPoint)
        {
            var leftFloatingPoint = (FloatingPoint) left;
            
            if (right.Type.EntityType == EntityType.FloatingPoint)
            {
                return leftFloatingPoint.Data > (right as FloatingPoint).Data;
            }
            
            if (right.Type.EntityType == EntityType.Integer)
            {
                return leftFloatingPoint.Data > (right as Integer).Data;
            }

            throw new InvalidArgument(PredicateType.GreaterThan, left.Type.EntityType, right.Type.EntityType);
        }
        
        throw new UnsupportedType(PredicateType.GreaterThan, left.Type.EntityType);
    }

    private static bool PredicateGreaterThanOrEqual(Entity left, Entity right)
    {
        return PredicateGreaterThan(right, left) || PredicateEqual(left, right);
    }

    private static bool PredicateLessThan(Entity left, Entity right)
    {
        return !PredicateGreaterThanOrEqual(left, right);
    }
    
    private static bool PredicateLessThanOrEqual(Entity left, Entity right)
    {
        return !PredicateGreaterThan(right, left);
    }
}