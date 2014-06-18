using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	public GUITexture upButton;
	public GUITexture downButton;
	public GUITexture weapon;
	void Start () 
	{
		SetGUICoordinates();
	}

	void SetGUICoordinates()
	{
		float margin = Screen.height / 25f; 
		float buttonSize = Screen.width / 15;
		float tempY = margin ;
		float tempY2 = 2* margin +  buttonSize;		 
		
		upButton.pixelInset = new Rect (margin, tempY2 , buttonSize, buttonSize);
		downButton.pixelInset = new Rect (margin, tempY, buttonSize, buttonSize);
		
		//upButton.pixelInset = new Rect(Screen.width - (margin + buttonSize),Screen.height -  tempY, buttonSize,buttonSize);
		weapon.pixelInset = new Rect(Screen.width - (margin + buttonSize), tempY, buttonSize,buttonSize);
	}
}
