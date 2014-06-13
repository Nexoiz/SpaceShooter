using UnityEngine;
using System.Collections;

public class Enemy : Ship 
{
	public int damage = 50;
	public int point = 10;
	public SpawnEnemy spawner;
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
		if(col.gameObject.CompareTag("Player"))
		{
			HealthClass hc = col.gameObject.GetComponent<HealthClass>();
			hc.Health = damage;
			spawner.RemoveEnemy(gameObject);
			Destroy (gameObject);
		}
	}
	public override void Move(float translation)
	{
		transform.Translate (translation * Time.deltaTime, 0, 0, Space.World);
	}
}