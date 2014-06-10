using UnityEngine;
using System.Collections;

public class PlayerControl : Ship {

	public float speed = 20;
	public Transform topPosition;
	public Transform bottomPosition;
	public Texture buttonUp;
	public Texture buttonDown;
	private GUIStyle myGUIStyle = new GUIStyle();
	public GUIStyle myStyleUp;
	public GUIStyle myStyleDown;

	private Rect upRect, downRect, aRect, bRect;

	void Start () 
	{
		float margin = Screen.height / 25f; 
		float buttonSize = Screen.width / 15;
		float tempY = margin +  buttonSize;
		float tempY2 = 2* margin +  2 * buttonSize;



		upRect = new Rect (margin, Screen.height - tempY2 , buttonSize, buttonSize);
		downRect = new Rect (margin, Screen.height - tempY, buttonSize, buttonSize);

		aRect = new Rect(Screen.width - (margin + buttonSize),Screen.height -  tempY, buttonSize,buttonSize);
		bRect = new Rect(Screen.width - (margin + buttonSize), Screen.height - tempY2, buttonSize,buttonSize);


		myTransform = GetComponent<Transform>();
		velocity = new Vector3(3.0f,0,0);
	}
	
	void Update () 
	{
		myTransform.Translate (velocity.x * Time.deltaTime, 0, 0, Space.World);
	}
	
	void FixedUpdate () {
		float translation = Input.GetAxis ("Vertical"); // * Time.deltaTime;
		if(translation == 0) return;
		MovePad (translation);
	}

	void MovePad(float movement){
		Vector3 pos = transform.position;
		pos.y = pos.y + movement * speed * Time.deltaTime;
		pos.y = Mathf.Clamp(pos.y, bottomPosition.position.y, topPosition.position.y);
		transform.position = pos;
// 		transform.Translate (0, translation, 0);	
	}
	void OnGUI () 
	{
		
		if (GUI.RepeatButton (upRect,"", myStyleUp)) {
			MovePad(1);	
		}
		if (GUI.RepeatButton (downRect, "", myStyleDown)) {
			MovePad(-1);
		}
		if(GUI.Button (aRect, "weapon1"))
		{

		}
		if(GUI.Button (bRect, "weapon2"))
		{

		}

	}
}