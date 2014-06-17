using UnityEngine;
using System.Collections;

public class AsteroidExplosion : MonoBehaviour 
{

	void Start () 
	{
		float speed = 5;
		Vector2[] velocity = new Vector2[4]; 
		Rigidbody2D[] children = GetComponentsInChildren<Rigidbody2D> ();
		velocity [0] = new Vector2 (-speed, -speed);
		velocity [1] = new Vector2 (speed, speed);
		velocity [2] = new Vector2 (speed, -speed);
		velocity [3] = new Vector2(-speed,speed);
		int length = children.Length;
		for (int i = 0; i < length; i++) 
		{
			children[i].transform.localPosition = Vector3.zero;
			children[i].velocity = velocity[i];
			children[i].renderer.enabled = true;
		}
		Destroy (gameObject, 0.3f);
	}
}
