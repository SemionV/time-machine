using TimeMachine.Domain.Entities;

namespace TimeMachine.Domain.TypeSystem;

public class FunctionType: CallableType
{
    public override EntityType EntityType => EntityType.Function;
}