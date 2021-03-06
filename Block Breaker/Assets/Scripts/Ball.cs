﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
	public Paddle paddle;
	private bool hasStarted = false; 
	private Vector3 paddleToBallVector;
	
	// Use this for initialization
	void Start ()
	{
		paddleToBallVector = this.transform.position - paddle.transform.position;
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!hasStarted) {
			// lock the ball relative to the paddle
			this.transform.position = paddle.transform.position + paddleToBallVector;
			//Wait for a mouse press to launch
			if (Input.GetMouseButtonDown (0)) {
				print ("Mouse Clicked, Ball Launched");
				this.rigidbody2D.velocity = new Vector2 (2f, 13f);
				hasStarted = true;
			}
		}
	}
}
