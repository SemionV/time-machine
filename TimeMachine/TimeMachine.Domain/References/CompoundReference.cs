using System.Text;

namespace TimeMachine.Domain.References;

public class CompoundReference
{
    public required IEnumerable<Reference> Path { get; set; }
}