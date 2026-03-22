using TimeMachine.Domain.TypeSystem;

namespace TimeMachine.Domain.Entities;

public class FunctionBinding: TypedEntity<FunctionBindingType>
{
    public FunctionBindingType.CallbackType Callback { get; }

    public FunctionBinding(FunctionBindingType type) : base(type)
    {
        Callback = type.Callback;
    }
}