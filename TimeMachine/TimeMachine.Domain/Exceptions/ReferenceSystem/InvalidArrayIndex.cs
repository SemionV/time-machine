namespace TimeMachine.Domain.Exceptions.ReferenceSystem;

public class InvalidArrayIndex:  Exception
{
    public int Index { get; }
    public int ArrayLength { get; }
    
    public InvalidArrayIndex(int index, int arrayLength)
    {
        Index = index;
        ArrayLength = arrayLength;
    }
}