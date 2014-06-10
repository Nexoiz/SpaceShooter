using UnityEngine;
using System.Collections;

public class FrontPage : GameManager {

	Rect rect = new Rect();

	Rect lvl1Rect, lvl2Rect, lvl3Rect;
	void Start () 
	{
		rect.width = Screen.width / 6;
		rect.height = Screen.height / 6;
		rect.x = Screen.width / 2 - rect.width /2;
		rect.y = Screen.height - rect.height;

		GUITexture background = GetComponent < GUITexture > ();
		background.pixelInset = new Rect (0, 0, Screen.width, Screen.height);
		state = State.Front;

		float buttonWidth = Screen.width / 10;
		float buttonHeight = Screen.height / 8;

		lvl1Rect = new Rect (Screen.width / 2 - buttonWidth * 2, Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight);
		lvl2Rect = new Rect (Screen.width / 2 - buttonWidth / 2, Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight);
		lvl3Rect = new Rect (Screen.width / 2 + buttonWidth , Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight);
	}

	void OnGUI () 
	{
		switch (state) 
		{
		case State.Front:
			if (GUI.Button (rect, "Click")) 
			{
				state = State.Selector;
			}
			break;
		case State.Selector:
			SelectorScreen();
			break;
		}
	}

	public void SelectorScreen () 
	{
		if (GUI.Button (lvl1Rect, "1")) 
		{
			Application.LoadLevel("Level1");
		}
		if (GUI.Button (lvl2Rect, "2")) {
			Application.LoadLevel("Level2");
		}
		if (GUI.Button (lvl3Rect, "3")) {
			Application.LoadLevel("Level3");
		}
	}
}
