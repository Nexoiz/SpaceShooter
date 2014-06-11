using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {



	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.CompareTag ("Enemy")) 
		{
			Destroy(col.gameObject);
			Destroy (gameObject);
		}
	}
}