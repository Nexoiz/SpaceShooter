using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour 
{

	public Sprite backSprite;
	
	void Start () 
	{
		GameManager.state = State.Running;
		CreateBackground();
	}
	
	void CreateBackground()
	{
		GameObject player = GameObject.Find ("Ship");
		// Creating background holder
		GameObject obj = new GameObject("Background");   
		obj.transform.position = Vector3.zero; 
		// Creating  the backgrounds
		for (int i = 0 ; i < 3 ; i++){
			GameObject objSub = new GameObject("Background");
			SpriteRenderer sr = objSub.AddComponent<SpriteRenderer>();
			sr.sprite = backSprite;
			objSub.transform.localScale = new Vector3(2,2,1);
			objSub.transform.parent = obj.transform;
			BackgroundScript bs =  objSub.AddComponent<BackgroundScript>();
			bs.player = player.transform;
			Vector3 pos = Vector3.zero;
			pos.x = 20 * i;
			objSub.transform.localPosition = pos;
		}
	}
}