using UnityEngine;
using System.Collections;

public class BackgroundScript : MonoBehaviour {

	public Transform player;
	private new Transform transform;
	void Start () 
	{
		transform = base.transform;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(player.position.x > transform.position.x && Vector3.Distance(player.position, transform.position) > 20.5f)
		{
			Vector3 vec = transform.localPosition;
			vec.x += 60;
			transform.localPosition = vec;
		}
	}
}
