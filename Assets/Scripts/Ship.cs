using UnityEngine;
using System.Collections;

public abstract class Ship : GameManager {
	
	protected Vector3 velocity;
	public int health;
	public abstract void Move(float translation);
	protected new Transform transform;

	protected virtual void Awake()
	{
		transform = base.transform;
	}
}