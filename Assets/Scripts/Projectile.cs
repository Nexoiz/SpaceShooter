using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public int damage;
	public AudioClip clip;

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.CompareTag ("Enemy")) 
		{
			Enemy enemy = col.gameObject.GetComponent<Enemy>();
			int score = enemy.point;
			enemy.spawner.RemoveEnemy(col.gameObject);
			GameObject.Find ("GameManager").GetComponent<ScoreClass>().Score = score;

			Destroy(col.gameObject);
			Destroy (gameObject);
			AudioSource.PlayClipAtPoint(clip, transform.position);
		}
	}
}