using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyMove : MonoBehaviour {
	public float xPos;
	public float yPos;
	public float zPos;


	// Use this for initialization
	void Start () {
		Vector3 lp = transform.localPosition;
		xPos = lp.x;
		yPos = lp.y;
		zPos = lp.z;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.localPosition = new Vector3(xPos+Mathf.Sin(Time.time),yPos+Mathf.Tan(Time.time+10f),zPos);
	}
}
