using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

	public GameObject enemy;
	Transform transform;

	void Start () {
		transform = base.transform;
		transform = GetComponent<Transform>();
		InvokeRepeating("CreateEnemy",0.5f,2.0f);
	}

	
	void CreateEnemy (){
		Vector3 enemyPos = new Vector3(transform.position.x,Random.Range (-5f,5f),0);
		Instantiate(enemy,enemyPos,transform.rotation);
	}

}