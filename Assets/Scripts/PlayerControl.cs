using UnityEngine;
using System.Collections;

public class PlayerControl : Ship {

	public float speed = 20;
	public Transform topPosition;
	public Transform bottomPosition;
	public GUIStyle myStyleUp;
	public GUIStyle myStyleDown;
	public Texture2D texturePause;
	public Shoot shootScript;
	
	private Rect upRect, downRect, aRect, bRect, dRect;

	void Start ()  
	{
		shootScript = gameObject.GetComponent<Shoot>();
		DeathZone ();
		SetGUICoordinates();

		velocity = new Vector3(3.0f,0,0);
	}

	void Update () 
	{
		float translation = 0;
		int count = Input.touchCount;
		for ( int i = 0; i < count; i++) 
		{
			Vector3 position = Input.GetTouch(i).position;
			position.y = (position.y - Screen.height) * -1;
			if(upRect.Contains(position))
			{
				translation = 1;
			}
			else if (downRect.Contains(position))
			{
				translation = -1;
			}
			else if (aRect.Contains (position))
			{
				shootScript.Shooting();
			}
			else if (bRect.Contains(position))
			{

			}
		}
		Move(translation);
	}

	public override void Move(float movement)
	{
		Vector3 pos = transform.position;
		pos.x += velocity.x * Time.deltaTime;
		pos.y = pos.y + movement * speed * Time.deltaTime;
		pos.y = Mathf.Clamp(pos.y, bottomPosition.position.y, topPosition.position.y);
		transform.position = pos;
	}
	void OnGUI () 
	{
		GUI.Box (upRect,"", myStyleUp);
		GUI.Box (downRect, "", myStyleDown);
		GUI.Box (aRect, "weapon1");
		GUI.Button (bRect, "");
	}
	void DeathZone()
	{
		GameObject obj = new GameObject ("DeathZone");
		obj.tag = "Deathzone";
		BoxCollider2D bc = obj.AddComponent<BoxCollider2D> ();
		bc.size = new Vector2 (1f,20f);
		DeathZoneScript dzs = obj.AddComponent<DeathZoneScript> ();
		dzs.target = transform;

	}
	void SetGUICoordinates()
	{
		float margin = Screen.height / 25f; 
		float buttonSize = Screen.width / 15;
		float tempY = margin +  buttonSize;
		float tempY2 = 2* margin +  2 * buttonSize;		 
		
		upRect = new Rect (margin, Screen.height - tempY2 , buttonSize, buttonSize);
		downRect = new Rect (margin, Screen.height - tempY, buttonSize, buttonSize);
		
		aRect = new Rect(Screen.width - (margin + buttonSize),Screen.height -  tempY, buttonSize,buttonSize);
		bRect = new Rect(Screen.width - (margin + buttonSize), Screen.height - tempY2, buttonSize,buttonSize);
	}
}