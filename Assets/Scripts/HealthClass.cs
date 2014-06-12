using UnityEngine;
using System.Collections;

public class HealthClass : MonoBehaviour 
{
	private int health;
	private int initialHealth = 50;
	private int lives = 1;

	public int Health
	{
		get
		{
			return health;
		}
		set
		{
			health -= value;

			if(health <= 0)
			{
				health = initialHealth;
				lives -= 1;
				if(lives < 0)
				{
					lives = 0;

					GetComponent<PlayerControl>().enabled = false;
					GetComponent<Shoot>().enabled = false;
					GetComponent<SpriteRenderer>().enabled = false;

					GameManager.state = State.GameOver;
				}
			}
		}
	}
	public GUIStyle myStyle;
	private Rect healthRect;
	private Rect livesRect;
	// Use this for initialization
	void Start () 
	{
		float box = Screen.width / 5;
		healthRect = new Rect(0,0, box , box / 3);
		livesRect = new Rect(Screen.width - box, 0 , box , box / 3);
		health = initialHealth;
	}
	
	// Update is called once per frame
	void OnGUI () 
	{
		myStyle.alignment = TextAnchor.MiddleLeft;
		GUI.Box (healthRect, health.ToString(), myStyle);

		myStyle.alignment = TextAnchor.MiddleRight;
		GUI.Box (livesRect, "LIFE: " + lives.ToString(), myStyle);
	}
}
