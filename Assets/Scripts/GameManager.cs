using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public State state = State.None;


public enum State {
	Running, Pause, None, Menu
}		
}