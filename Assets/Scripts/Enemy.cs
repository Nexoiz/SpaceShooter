using UnityEngine;
using System.Collections;

public class Enemy : Ship 
{
	public int damage = 50;
	public int point = 10;
	public SpawnEnemy spawner;
	public AudioClip clip;

	public virtual void Start () 
	{
		velocity = new Vector3(Random.Range(-5f,-1.5f),0,0);
	}
	
	public virtual void Update () 
	{
		Move (velocity.x);
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		GameObject obj = col.gameObject;

		if (obj.CompareTag("Bullet"))
		{
			spawner.RemoveEnemy(col.gameObject);
			GameObject.Find ("GameManager").GetComponent<ScoreClass>().Score = point;
			Destroy(obj);
			Destroy (gameObject);
			AudioSource.PlayClipAtPoint(clip, transform.position);
		}
		else if(obj.CompareTag ("Player"))
		{
			HealthClass hc = obj.GetComponent<HealthClass>();
			hc.Health = damage;
			spawner.RemoveEnemy(gameObject);
			Destroy (gameObject);
		}
		else if(obj.CompareTag("Deathzone"))
		{
			spawner.RemoveEnemy(obj);
			Destroy(obj);
		}
	}
	public override void Move(float translation)
	{
		transform.Translate (translation * Time.deltaTime, 0, 0, Space.World);
	}
}