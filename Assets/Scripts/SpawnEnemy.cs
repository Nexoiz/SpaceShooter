using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

	public GameObject enemy;
	Transform transform;
	void Start () {
		transform = GetComponent<Transform>();
		InvokeRepeating("CreateEnemy",0.01f,2.0f);
	}

	
	void CreateEnemy(){
		Vector3 enemyVec = new Vector3(transform.position.x,Random.Range (-5f,5f),0);
		Instantiate(enemy,enemyVec,transform.rotation);
	}
}