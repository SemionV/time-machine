using TimeMachine.Domain.Entities;

namespace TimeMachine.Domain.TypeSystem;

public class FunctionBindingType: CallableType
{
    public override EntityType EntityType => EntityType.FunctionBinding;
}