using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

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
}
	


public enum State {
	Running, Pause, None, Menu, GameOver, GameWon,  Front, Selector
}		
