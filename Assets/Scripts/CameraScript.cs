using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour 
{
	public Transform target;

	void Update () 
	{
		Vector3 pos;
		pos = transform.position;
		pos.x = target.position.x + 7;
		transform.position = pos;
	}
}
