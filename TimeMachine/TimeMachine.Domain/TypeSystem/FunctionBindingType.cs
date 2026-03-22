using TimeMachine.Domain.Entities;
using TimeMachine.Domain.References;

namespace TimeMachine.Domain.TypeSystem;

public class FunctionBindingType: CallableType
{
    public override EntityType EntityType => EntityType.FunctionBinding;
    public delegate Entity CallbackType(Dictionary<string, CompoundReference> arguments);
    public CallbackType Callback { get; }
    
    public FunctionBindingType(CallbackType callback)
    {
        Callback = callback;
    }
}