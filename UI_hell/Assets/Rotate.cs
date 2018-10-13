using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	public float xR;
	public float yR;
	public float zR;
	public float speed=1;
	// Update is called once per frame
	void FixedUpdate () {
		transform.Rotate(new Vector3(xR,yR,zR)*speed);	
	}
}
