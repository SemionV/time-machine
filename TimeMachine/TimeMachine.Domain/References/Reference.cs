namespace TimeMachine.Domain.References;

public class Reference
{
    public required IEnumerable<ObjectReference> Path { get; set; }
    public MemberReference Member { get; set; }
}