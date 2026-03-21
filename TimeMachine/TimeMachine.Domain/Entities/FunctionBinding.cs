using TimeMachine.Domain.References;

namespace TimeMachine.Domain.Data;

public class FunctionBinding: Entity
{
    public delegate Entity CallbackType(Dictionary<string, CompoundReference> arguments);
    
    public override EntityType Type => EntityType.FunctionBinding;
    public required CallbackType Callback { get; set; }
}