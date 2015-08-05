using Entitas;

public class $safeitemname$ : IExecuteSystem, ISetPool
{
	private Pool _pool;
	private Group _myGroup;
	
	public void SetPool(Pool pool)
	{
		_pool = pool;
		// _myGroup = pool.GetGroup(Matcher.AllOf(Matcher.Move, Matcher.Position));
	}
	
	public void Execute()
	{
		/*
		foreach (var e in _myGroup.GetEntities())
		{
			var	move = e.move;
			var pos = e.position;
			e.ReplacePosition(pos.x, pos.y + move.speed, pos.z);
		}
		*/
	}
}