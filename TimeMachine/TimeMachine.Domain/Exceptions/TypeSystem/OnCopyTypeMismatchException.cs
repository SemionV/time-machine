namespace TimeMachine.Domain.Exceptions.TypeSystem;
using Type = TimeMachine.Domain.TypeSystem.Type;

public class OnCopyTypeMismatchException: Exception
{
    public Type SourceType { get; }
    public Type TargetType { get; }

    public OnCopyTypeMismatchException(Type sourceType, Type targetType)
    {
        SourceType = sourceType;
        TargetType = targetType;
    }
}