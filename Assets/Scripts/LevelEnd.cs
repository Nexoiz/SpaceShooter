using UnityEngine;
using System.Collections;

public class LevelEnd : MonoBehaviour 
{
	bool isOver = false;
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.CompareTag ("Player")) 
		{
			
			GameManager.state = State.GameWon;
			GameManager.StateChecker ();
			StartCoroutine(CheckForRemainingEnemies());
		}
	}
	
	IEnumerator CheckForRemainingEnemies () 
	{
		while(Enemy.enemies.Count > 0) 
		{
			yield return null;
		}
		isOver = true;
		SpawnEnemy.ClearEvent();
		while(true)
		{
			if(Input.touches.Length > 0 || Input.anyKeyDown)
			{
				Application.LoadLevel("FrontPage");
			}
			yield return null;
		}
	}
	void OnGUI()
	{
		if(isOver)
		{
			float boxSize = Screen.width / 2;
			float boxHeight = Screen.height / 2;
			GUI.Box(new Rect(Screen.width / 2 - boxSize / 2,
			                 Screen.height / 2 - boxHeight / 2,
			                 boxSize, boxHeight), "You won");
		}
	}
}
