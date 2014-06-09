using UnityEngine;
using System.Collections;

public class Player: Ship {

	//public weapon [] weapons;

	private float playerSpeed = 4f;

	public void Move(float horizontal, float vertical) {
	}
	// SHOOTING HAS BEEN COMMENTED OUT
	/*public override void ShootPrimary() {
		weapons [0].Shoot ();
	}

	public override void ShootSecondary() {
		weapons [1].Shoot();
	}*/
	public void Update() {
		/*if (Input.GetKeyDown (KeyCode.A)) {
			ShootPrimary ();
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			ShootSecondary ();
		}*/
	
		if (Input.GetKey(KeyCode.UpArrow))
			this.transform.position += Vector3.up * playerSpeed * Time.deltaTime;
		if (Input.GetKey(KeyCode.DownArrow))
			this.transform.position += Vector3.down * playerSpeed *  Time.deltaTime;
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.CompareTag ("Ball1")){
			print ("Player: Collision happened");
			col.transform.position = new Vector3(5,0,0);
		} 
		else if (col.gameObject.CompareTag ("Ball2")) {
			print ("Player: Collision happened");
			col.transform.position = new Vector3(5,3,0);
		}

	}
}
