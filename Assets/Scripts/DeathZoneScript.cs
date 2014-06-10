using UnityEngine;
using System.Collections;

public class DeathZoneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col) 
	{
		if (col.gameObject.CompareTag ("Enemy")) 
		{
			Destroy(col.gameObject);
		}
	}
}
