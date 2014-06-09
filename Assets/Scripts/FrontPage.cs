using UnityEngine;
using System.Collections;

public class FrontPage : GameManager {
	Rect rect = new Rect();
	// Use this for initialization
	void Start () {
		rect.width = Screen.width / 6;
		rect.height = Screen.height / 6;
		rect.x = Screen.width / 2 - rect.width /2;
		rect.y = Screen.height - rect.height;

		GUITexture background = GetComponent < GUITexture > ();
		background.pixelInset = new Rect (0, 0, Screen.width, Screen.height);
	}
	
	// Update is called once per frame
	void OnGUI () {
		if (GUI.Button (rect, "Click"))
						Application.LoadLevel ("LevelSelect");
	
	}
}
