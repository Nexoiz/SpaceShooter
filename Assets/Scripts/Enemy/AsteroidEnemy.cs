using UnityEngine;
using System.Collections;

public class AsteroidEnemy : Enemy {

	public GameObject explosion;
	// Use this for initialization
	protected override void Start () 
	{
		base.Start ();
		//explosion.SetActive (false);
	}

	protected override void OnCollisionEnter2D(Collision2D col)
	{
		base.OnCollisionEnter2D (col);
		Instantiate (explosion, transform.position, Quaternion.identity);
	}
}
