using UnityEngine;
using System.Collections;

public class HealthClass : MonoBehaviour 
{
	private int health;
	private int initialHealth = 500;
	private int lives = 3;

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
	private Texture2D texture ;

	void Start () 
	{
		texture = new Texture2D(1, 1);
		float box = Screen.width / 5;
		healthRect = new Rect(0,0, box , box / 5);
		livesRect = new Rect(Screen.width - box, 0 , box , box / 3);
		health = initialHealth;
	}
	
	// Update is called once per frame
	void OnGUI () 
	{
		float box = Screen.width / 5;
		healthRect.width = box;
		DrawQuad (healthRect, Color.red);

		float ratio = (float)health / (float)initialHealth;
		healthRect.width = box * ratio;
		DrawQuad (healthRect, Color.green);
		myStyle.alignment = TextAnchor.MiddleRight;
		GUI.Box (livesRect, "LIFE: " + lives.ToString(), myStyle);
	}


 
	void DrawQuad(Rect position, Color color) 
	{
		texture.SetPixel(0,0,color);
		texture.Apply();
		GUI.skin.box.normal.background = texture;
		GUI.Box(position, GUIContent.none);
	}
}
