using UnityEngine;
using System.Collections;

public class Enemy : Ship {

	public int point = 10;
	public virtual void Start () 
	{
		myTransform = GetComponent<Transform>();
		velocity = new Vector3(Random.Range(1.5f,5.0f),0,0);
	}
	
	public virtual void Update () 
	{
		myTransform.Translate (-velocity.x * Time.deltaTime, 0, 0, Space.World);
	}

}