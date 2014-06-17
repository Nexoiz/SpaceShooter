using UnityEngine;
using System.Collections.Generic;

public class SpawnEnemy : MonoBehaviour {
	
	public delegate void CreateEnemy();
	public static event CreateEnemy OnCreateEnemy;
	
	public LevelMethod startLevel;
	
	void Start () 
	{
		OnCreateEnemy += startLevel.CreateEnemies;
	}
	
	void Update ()
	{
		if (GameManager.state != State.Running)return;
		
		if(OnCreateEnemy != null)
			OnCreateEnemy();
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.CompareTag("SpawnerMethod"))
		{
			OnCreateEnemy = null;
			OnCreateEnemy += col.gameObject.GetComponent<LevelMethod>().CreateEnemies;
		}
	}
	public static void ClearEvent()
	{
		OnCreateEnemy = null;
	}
}