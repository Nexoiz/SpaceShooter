using UnityEngine;
using System.Collections;

public class DeathZoneScript : MonoBehaviour {
	public Transform target;

	void Update () {
		Vector3 pos;
		pos = transform.position;
		pos.x = target.position.x - 8;
		transform.position = pos;
	}
}
