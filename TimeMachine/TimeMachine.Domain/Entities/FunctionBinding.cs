using TimeMachine.Domain.References;
using TimeMachine.Domain.TypeSystem;

namespace TimeMachine.Domain.Entities;

public class FunctionBinding: TypedEntity<FunctionBindingType>
{
    public delegate Entity CallbackType(Dictionary<string, CompoundReference> arguments);

    public required CallbackType Callback { get; set; }

    public FunctionBinding(FunctionBindingType type) : base(type)
    {
    }
}