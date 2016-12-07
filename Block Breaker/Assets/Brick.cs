using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour
{
	public int maxHits;
	private int timesHit;
	// Use this for initialization
	void Start ()
	{
		timesHit = 0;
		//maxHits = 3;
	}
	
	void OnCollisionEnter2D (Collision2D collision)
	{
		timesHit += 1;
		print (timesHit);
	}
	
}
