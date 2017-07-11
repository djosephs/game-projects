using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour
{
	public int maxHits;
	private int timesHit;
	private LevelManager levelManager;
	// Use this for initialization
	void Start ()
	{
		timesHit = 0;
		maxHits = 3;
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	void OnCollisionEnter2D (Collision2D collision)
	{
		timesHit += 1;
		print (timesHit);
		SimulateWin ();
	}
	//TODO remove this method
	void SimulateWin ()
	{
		levelManager.LoadNextLevel ();
	}
}