using TimeMachine.Domain.References;

namespace TimeMachine.Domain.Data;

public interface IValue<TValue>: IObject
{
    void Write(TValue value, CompoundReference from, CompoundReference to);
    TValue Read(CompoundReference from, CompoundReference to);
}