using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		GameManager.state = State.Running;
	}
}
