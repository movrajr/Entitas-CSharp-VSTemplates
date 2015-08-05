using Entitas;
using System.Collections.Generic;

public class $safeitemname$ : IReactiveSystem, ISetPool
{
	public IMatcher trigger { get { return Matcher.Input; } }

    public GroupEventType eventType { get { return GroupEventType.OnEntityAdded; } }

    private Pool _pool;

    public void SetPool(Pool pool)
    {
        _pool = pool;
    }
    
    public void Execute(List<Entity> entities)
    {
        // UnityEngine.Debug.Log("$safeitemname$");

        /*
        foreach (var e in entities) {
            _pool.DestroyEntity(e);
        }
        */
    }
}