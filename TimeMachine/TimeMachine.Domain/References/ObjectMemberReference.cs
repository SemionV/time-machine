namespace TimeMachine.Domain.References;

public class ObjectMemberReference: Reference
{
    public override ReferenceType Type => ReferenceType.ObjectMember;
    public required string Key { get; set; }
}