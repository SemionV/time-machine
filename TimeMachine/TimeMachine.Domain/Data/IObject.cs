namespace TimeMachine.Domain.Data;

public interface IObject
{
    ObjectType Type { get; }
}