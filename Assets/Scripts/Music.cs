using UnityEngine;
using System.Collections;


public class Music : MonoBehaviour {
	static Music instance = null;
	void Start () {
		if (instance == null) {
			instance = this;

		}
		else if(instance != this)
		{
			Destroy(gameObject);
			return;
		}
		DontDestroyOnLoad (gameObject);
	}
	
}
