using TimeMachine.Domain.Entities;
using TimeMachine.Domain.Exceptions.Logic.Predicates;
using TimeMachine.Domain.LogicalOperators;
using TimeMachine.Domain.Predicates;

namespace ExecutionEngine;

public class LogicProcessor
{
    public static bool Process(Operator op)
    {
        if (op.Type == LogicalOperatorType.Unary)
        {
            var unaryOperator = op as UnaryOperator;
            
            return Process(unaryOperator.Argument);
        }
        
        if (op.Type == LogicalOperatorType.Predicate)
        {
            return ProcessOperator(op as BinaryOperator, (l, r) => l && r);
        }
        
        if (op.Type == LogicalOperatorType.Unary)
        {
            var unaryOperator = op as UnaryOperator;
            if(unaryOperator == null)
                throw new ArgumentException();
            return Process(unaryOperator.Argument);
        }
        
        if (op.Type == LogicalOperatorType.And)
        {
            return ProcessOperator(op as BinaryOperator, (l, r) => l && r);
        }

        return false;
    }

    private static bool ProcessOperator(BinaryOperator? op, Func<bool, bool, bool> proposition)
    {
        if(op == null)
            throw new ArgumentException();
        var leftTruth = Process(op.Left);
        var rightTruth = Process(op.Right);
        return proposition(leftTruth, rightTruth);
    }

    public static bool Process(Predicate predicate)
    {
        
        
        return false;
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

            throw new InvalidArgumentEqual(left.Type.EntityType, right.Type.EntityType);
        }
    }
}