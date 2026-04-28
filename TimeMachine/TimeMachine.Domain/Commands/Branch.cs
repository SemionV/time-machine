using TimeMachine.Domain.Execution;
using TimeMachine.Domain.LogicalOperators;

namespace TimeMachine.Domain.Commands;

public class Branch: Command
{
    public override Instruction Instruction => Instruction.Branch;
    public required Operator LogicalOperator { get; set; }
    public ExecutionNode TrueBranch { get; set; }
    public ExecutionNode FalseBranch { get; set; }
}