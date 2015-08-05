using Entitas;

public class $safeitemname$ : IStartSystem, ISetPool
{
	private Pool _pool;

    public void SetPool(Pool pool)
    {
        _pool = pool;
    }

    public void Start()
    {
    	/*
        for (int i = 1; i < 10; i++)
        {
            var speed = UnityEngine.Random.value * 0.02f;
            _pool.CreateEntity()            	
                .AddResource(MyResources.Opponent.Path)
                .AddPosition(i + i, 0, 0)
                .AddMove(speed, speed);
        }
        */
    }
}