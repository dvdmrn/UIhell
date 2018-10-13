using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingLinearMove : MonoBehaviour {

	
	float xOrg;
	float yOrg;
	float zOrg;
	public float speed = 1f;

	float newX;

	public float width;

	// Use this for initialization
	void Start () {
	xOrg= transform.localPosition.x;		
	yOrg= transform.localPosition.y;		
	xOrg= transform.localPosition.z;
	newX = xOrg;

	}
	
	// Update is called once per frame
	void Update () {
		float pos = (Time.time%width) - 1f;
		transform.localPosition = new Vector3(pos*speed,yOrg,zOrg);
	}
}
