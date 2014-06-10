using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public string strWin = "You Won!";

	public static State state = State.None;

	public void StateChecker()
	{
		if (state == State.GameWon) 
		{
			Time.timeScale = 0.0f;
		}
	}

	void OnGUI()
		{
		if (state == State.GameWon) 
			{
			GUI.TextField (new Rect (Screen.width/2, Screen.height/2, 300, 50), strWin, 50);
			}
		}
	


public enum State {
	Running, Pause, None, Menu, GameOver, GameWon
}		
}