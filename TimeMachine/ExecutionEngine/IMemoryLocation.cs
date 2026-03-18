using TimeMachine.Domain;
using TimeMachine.Domain.Data;

namespace ExecutionEngine;

public interface IMemoryLocation
{
    void WriteValue(IValue value);
    IValue ReadValue();
}