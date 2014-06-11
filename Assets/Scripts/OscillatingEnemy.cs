using UnityEngine;
using System.Collections;

public class OscillatingEnemy : Enemy {
	public float amplitude = 2f;
	public float omega = 0.5f;
	public float index = 0;

	public override void Start () {
		base.Start ();

	}
	

	public override void Update () {
		index += Time.deltaTime;
		Vector3 vPos = transform.position;
		vPos.y = amplitude*(Mathf.Cos(omega*index))*Time.deltaTime;
		transform.position = vPos;
	}
}
