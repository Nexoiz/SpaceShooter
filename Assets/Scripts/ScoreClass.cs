using UnityEngine;
using System.Collections;

public class ScoreClass: MonoBehaviour {

	public int score;

	public ScoreClass () {
		score = 0;
	}

	public int GetScore() {
		return score;
	}

	public void SetScore (int value) {
		if (value < 1) return;
		score = score + value;
	}

	public void ResetAll () {
		score = 0;
	}

}