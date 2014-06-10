using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	private Rect cRect;


	void Start()
	{
		float margin = Screen.height / 25f; 
		float buttonSize = Screen.width / 15;
		float tempY3 = 7* margin + 6.5f * buttonSize;
		cRect = new Rect(Screen.width - (margin + buttonSize), Screen.height - tempY3, buttonSize,buttonSize);
	}
	
	void OnGUI()
	{
		switch (GameManager.state) 
		{
		case State.Running:
			DrawPauseButton();
			break;
		case State.Pause:
			DrawPlayButton();
			break;
		}
	}
	void DrawPauseButton()
	{
		if (GUI.Button (cRect, "pause")) 
		{
			GameManager.state = State.Pause;
			GameManager.StateChecker();
		}
	}
	void DrawPlayButton()
	{
		if (GUI.Button (cRect, "play")) 
		{
			GameManager.state = State.Running;
			GameManager.StateChecker();
		}
	}
}
