using UnityEngine;
using System.Collections;

public class FrontPage : GameManager {

	Rect buttonRect;
	Rect lvl1Rect, lvl2Rect, lvl3Rect;

	void Start () 
	{
		Init ();
	}

	void OnGUI () 
	{
		switch (state) 
		{
		case State.Front:
			FrontPageButton();
			break;
		case State.Selector:
			SelectorScreen();
			break;
		}
	}

	private void FrontPageButton()
	{
		if (GUI.Button (buttonRect, "Click")) 
		{
			state = State.Selector;
		}
	}
	private void SelectorScreen () 
	{
		if (GUI.Button (lvl1Rect, "1")) 
		{
			Application.LoadLevel("Level1");
		}
		if (GUI.Button (lvl2Rect, "2")) 
		{
			Application.LoadLevel("Level2");
		}
		if (GUI.Button (lvl3Rect, "3")) 
		{
			Application.LoadLevel("Level3");
		}
	}

	private void Init()
	{
		buttonRect = new Rect ();
		buttonRect.width = Screen.width / 6;
		buttonRect.height = Screen.height / 6;
		buttonRect.x = Screen.width / 2 - buttonRect.width /2;
		buttonRect.y = Screen.height - buttonRect.height;
		
		GUITexture background = GetComponent < GUITexture > ();
		background.pixelInset = new Rect (0, 0, Screen.width, Screen.height);
		state = State.Front;
		
		float buttonWidth = Screen.width / 10;
		float buttonHeight = Screen.height / 8;
		
		lvl1Rect = new Rect (Screen.width / 2 - buttonWidth * 2, Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight);
		lvl2Rect = new Rect (Screen.width / 2 - buttonWidth / 2, Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight);
		lvl3Rect = new Rect (Screen.width / 2 + buttonWidth , Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight);
	}
}
