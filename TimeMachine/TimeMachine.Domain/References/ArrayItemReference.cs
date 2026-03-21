namespace TimeMachine.Domain.References;

public class ArrayItemReference: Reference
{
    public override ReferenceType Type => ReferenceType.ArrayItem;
    public int Index { get; set; }
}