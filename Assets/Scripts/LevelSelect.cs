using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelSelect : GameManager {

	void OnGUI () {

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
