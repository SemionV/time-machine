using TimeMachine.Domain.Entities;
using TimeMachine.Domain.Exceptions.ReferenceSystem;
using TimeMachine.Domain.References;
using Array = TimeMachine.Domain.Entities.Array;
using Object = TimeMachine.Domain.Entities.Object;

namespace ExecutionEngine;

public class ReferenceResolver
{
    public static Entity Resolve(CompoundReference compoundReference, Entity containerEntity)
    {
        Entity entity = containerEntity;
            
        foreach (var reference in compoundReference.Path)
        {
            if (entity == null)
                throw new ReferenceResolutionException();
                
            if (reference.Type == ReferenceType.ArrayItem)
            {
                if (entity.Type.EntityType == EntityType.Array)
                {
                    var index = (reference as ArrayItemReference).Index;
                    var array = entity as Array;
                    if(index < 0 || index >= array.Length)
                        throw new InvalidArrayIndex(index, array.Length);
                    entity = array[index];
                }
                else
                {
                    //TODO: build useful error message with custom ReferenceResolutionException
                    throw new ReferenceResolutionException();
                }
            }
            else if(reference.Type == ReferenceType.ObjectMember)
            {
                if (entity.Type.EntityType == EntityType.Object)
                {
                    var key = (reference as ObjectMemberReference).Key;
                    (entity as Object).Fields.TryGetValue(key, out entity);
                }
                else
                {
                    throw new ReferenceResolutionException();
                }
            }
            else
            {
                throw new ReferenceResolutionException();
            }
        }
        
        return entity;
    }
}