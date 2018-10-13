using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoomy : MonoBehaviour {
	float xPos;
	float yPos;
	float zPos;
	public float xMag;
	public float yMag;
	public float zMag;

	public float amp;

	// Use this for initialization
	void Start () {
		Vector3 lp = transform.localPosition;
		xPos = lp.x;
		yPos = lp.y;
		zPos = lp.z;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.localPosition = new Vector3(xPos+(Mathf.Sin(Time.time)*amp)+xMag,
											yPos+(Mathf.Sin(Time.time)*amp)+yMag,
											zPos+(Mathf.Sin(Time.time)*amp)+zMag);
	}
}
