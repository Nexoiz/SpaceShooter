using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : Ship 
{
	public int damage = 50;
	public int point = 10;
	public SpawnEnemy spawner;
	public AudioClip clip;
<<<<<<< HEAD
	public static List<GameObject> enemies = new List<GameObject>();
	
=======
	static List<GameObject> enemies = new List<GameObject>();
	public GameObject explosion;
>>>>>>> 54d0774df1244892f161008a6654a7e732d6d879
	protected virtual void Start () 
	{
		velocity = new Vector3(Random.Range(-5f,-1.5f),0,0);
		enemies.Add (gameObject);
	}
	
	protected virtual void Update () 
	{
		Move (velocity.x);
	}
	protected virtual void OnCollisionEnter2D(Collision2D col)
	{
		GameObject obj = col.gameObject;
		
		if (obj.CompareTag("Bullet"))
		{
			enemies.Remove(gameObject);
			GameObject.Find ("GameManager").GetComponent<ScoreClass>().Score = point;
			Destroy(obj);
			Destroy (gameObject);
			if(explosion != null)Instantiate (explosion, transform.position, Quaternion.identity);
			AudioSource.PlayClipAtPoint(clip, transform.position);
		}
		else if(obj.CompareTag ("Player"))
		{
			HealthClass hc = obj.GetComponent<HealthClass>();
			hc.Health = damage;
			enemies.Remove(gameObject);
			Destroy (gameObject);
<<<<<<< HEAD
=======
			if(explosion != null)Instantiate (explosion, transform.position, Quaternion.identity);
			AudioSource.PlayClipAtPoint(clip, transform.position);
>>>>>>> 54d0774df1244892f161008a6654a7e732d6d879
		}
		else if(obj.CompareTag("Deathzone"))
		{
			enemies.Remove(gameObject);
			Destroy(gameObject);
		}
	}
	public override void Move(float translation)
	{
		transform.Translate (translation * Time.deltaTime, 0, 0, Space.World);
	}
}