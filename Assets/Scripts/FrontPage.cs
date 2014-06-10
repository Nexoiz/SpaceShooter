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
		state = State.Front;
	}

	// Update is called once per frame
	void OnGUI () {

		switch (state) {

		case State.Front:
			if (GUI.Button (rect, "Click")) 
				state = State.Selector;
			break;
		case State.Selector:
			SelectorScreen();
			break;

		}
	}

	public void SelectorScreen () {
		
		float buttonWidth = Screen.width / 10;
		float buttonHeight = Screen.height / 8;
		
		if (GUI.Button (new Rect (Screen.width / 2 - buttonWidth * 2, Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight), "Buttoooon1")) {
			Application.LoadLevel("Level1");
		}
		if (GUI.Button (new Rect (Screen.width / 2 - buttonWidth / 2, Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight), "Buttoooon2")) {
			Application.LoadLevel("Level2");
		}
		if (GUI.Button (new Rect (Screen.width / 2 + buttonWidth , Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight), "Buttoooon3")) {
			Application.LoadLevel("Level3");
		}
	}
}
