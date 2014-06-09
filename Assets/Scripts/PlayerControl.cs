using UnityEngine;
using System.Collections;

public class PlayerControl : Ship {

	public float speed = 20;
	public Transform topPosition;
	public Transform bottomPosition;
	public GameManager gm;

	void Start () {
		myTransform = GetComponent<Transform>();
		velocity = new Vector3(3.0f,0,0);
	}
	
	void Update () {
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
	void OnGUI () {
		
		GUI.Box(new Rect(0,Screen.height - 110,100,120), "Movement");
		
		if (GUI.RepeatButton (new Rect (20, Screen.height - 90, 50, 40), "Up")) {
			MovePad(1);	
		}
		if (GUI.RepeatButton (new Rect (20, Screen.height - 40, 50, 40), "Down")) {
			MovePad(-1);
		}
		GUI.Box(new Rect(Screen.width - 100,Screen.height - 150,100,100), "weapons");
		GUI.Button (new Rect(Screen.width - 100,Screen.height - 120,100,50), "weapon1");
		GUI.Button (new Rect(Screen.width - 100,Screen.height - 50,100,50), "weapon2");
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.CompareTag ("Ending")) 
		{
			GameManager.state = State.GameOver;
			print ("You Win!");
		}
	}
}