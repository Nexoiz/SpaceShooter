using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos;
		pos = transform.position;
		pos.x = target.position.x + 7;
		transform.position = pos;
	}
}
