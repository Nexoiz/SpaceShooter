using UnityEngine;
using System.Collections;

public class Meteor : Enemy {

	public override void Start () {
		velocity = new Vector3(Random.Range(1.5f,5.0f),0,0);
	}
	
	public override void Update () {
		transform.Translate ( -velocity.x * Time.deltaTime, 0, 0, Space.World);
	}
}
