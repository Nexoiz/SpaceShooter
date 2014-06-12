using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public int damage;
	public AudioClip clip;

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.CompareTag ("Enemy")) 
		{
			int score = col.gameObject.GetComponent<Enemy>().point;
			GameObject.Find ("GameManager").GetComponent<ScoreClass>().Score = score;

			Destroy(col.gameObject);
			Destroy (gameObject);
			AudioSource.PlayClipAtPoint(clip, transform.position);
		}
	}
}