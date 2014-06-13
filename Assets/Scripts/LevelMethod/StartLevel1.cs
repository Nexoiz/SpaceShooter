using UnityEngine;
using System.Collections;

public class StartLevel1 : LevelMethod {

}

public  class LevelMethod:MonoBehaviour
{
	protected Transform spawnerPoint;
	public GameObject prefab;
	public float frequency = 1; 
	protected float timer = 0;

	void Start () 
	{
		spawnerPoint = GameObject.Find("Spawner").transform;
	}
	public virtual void CreateEnemies()
	{
		if(timer < frequency)
		{
			timer += Time.deltaTime;
			return;
		}
		
		timer = 0;
		Vector3 enemyPos = new Vector3(spawnerPoint.position.x,Random.Range (-5f,5f),0);
		Instantiate(prefab,enemyPos,transform.rotation);
	}
}
