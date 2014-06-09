using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static State state = State.None;


public enum State {
	Running, Pause, None, Menu, GameOver
}		
}