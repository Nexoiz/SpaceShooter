using UnityEngine;
using System.Collections;

public class ScoreClass: MonoBehaviour {

	private static int score;
	private Rect scoreRect;
	public GUIStyle myStyle;

	void Start()
	{
		float box = Screen.width / 5;
		scoreRect = new Rect(Screen.width/2 - box / 2, 0, box, box / 3);
	}
	public int Score
	{
		get{
			return score;
		}
		set
		{
			if (value < 1) return;
			score = score + value;
		}
	}

	public void ResetAll () {
		score = 0;
	}
	private string strScore = "SCORE: "; 
	void OnGUI()
	{
		GUI.Box(scoreRect, strScore + score.ToString(),myStyle);
	}
}