using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public string strWin = "You Won!";

	public static State state = State.None;

	public static void StateChecker()
	{
		if (state == State.GameWon) 
		{
			Time.timeScale = 0.0f;
		}
		if (state == State.Pause) 
		{
			Time.timeScale = 0.0f;
		}
		if (state == State.Running) 
		{
			Time.timeScale = 1.0f;
		}
	}

	/*void OnGUI()
		{
		if (state == State.GameWon) 
			{
			GUI.TextField (new Rect (Screen.width/2, Screen.height/2, 300, 50), strWin, 50);
			}*/
}
	


public enum State {
	Running, Pause, None, Menu, GameOver, GameWon
}		
