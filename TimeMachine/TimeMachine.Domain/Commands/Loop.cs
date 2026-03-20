using TimeMachine.Domain.Execution;
using TimeMachine.Domain.LogicalOperators;

namespace TimeMachine.Domain.Commands;

public abstract class Loop: Command
{
    public required Operator LogicalOperator { get; set; }
}