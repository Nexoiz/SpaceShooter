using UnityEngine;
using System.Collections;

public class DeathZoneScript : MonoBehaviour {
	public Transform target;

	void Update () {
		Vector3 pos;
		pos = transform.position;
		pos.x = target.position.x - 8;
		transform.position = pos;
	}
	

	void OnCollisionEnter2D (Collision2D col) 
	{
		if (col.gameObject.CompareTag ("Enemy")) 
		{
			GameObject obj = col.gameObject;
			obj.GetComponent<Enemy>().spawner.RemoveEnemy(obj);
			Destroy(obj);
		}
	}
}
