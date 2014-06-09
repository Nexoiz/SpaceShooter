using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	private float timer;
	private float fireRate = 0.2f;
	public GameObject Bullet;
	public Transform ShootPos;
	public float Speed;

	public float FireRate 
	{
				get;
				set;
	}

	void Update () 
	{
		timer += Time.deltaTime;
		if (timer > fireRate) 
		{
			timer = 0;
			ShootAction();
		}
	}
	void ShootAction ()
	{
		GameObject sphere = (GameObject)Instantiate (Bullet, ShootPos.position, Quaternion.identity);
		sphere.rigidbody2D.velocity = new Vector2 (8, 0);
		Destroy (sphere, 5.0f);
	}
}
