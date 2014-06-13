using UnityEngine;
using System.Collections.Generic;

public class SpawnEnemy : MonoBehaviour {

	public GameObject enemy;
	public GameObject enemyOsc;
	private new	Transform transform;
	private List<GameObject> enemies;
	void Start () 
	{
		enemies = new List<GameObject>();
		transform = base.transform;
		InvokeRepeating("CreateEnemy",0.5f,2.0f);
	}
	void Update()
	{
		print (enemies.Count);
	}
	void CreateEnemy ()
	{
		Vector3 enemyPos = new Vector3(transform.position.x,Random.Range (-5f,5f),0);
		GameObject obj = (GameObject)Instantiate(enemy,enemyPos,transform.rotation);
		obj.GetComponent<Enemy>().spawner = this;
		enemies.Add(obj);

		obj = (GameObject)Instantiate(enemyOsc,enemyPos,transform.rotation);
		obj.GetComponent<Enemy>().spawner = this;
		enemies.Add (obj);
	}
	public void RemoveEnemy(GameObject obj)
	{
		enemies.Remove(obj);
	}
}