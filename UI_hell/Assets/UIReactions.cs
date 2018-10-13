using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIReactions : MonoBehaviour {

	Vector3 scale;
	Vector3 pos;
	// Use this for initialization
	void Start () {
	scale = transform.localScale; 
	pos = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void Rescale(Slider slider){
		float val = slider.value;
		transform.localScale = new Vector3(scale.x+val,scale.y+val,scale.z+val);
	}

	public void move(Slider slider){
		float val = slider.value;
		transform.localPosition = new Vector3(pos.x,pos.y+(val-0.5f),pos.z);
	}

	public void Clicky(){
		transform.Rotate(new Vector3(Random.Range(0,360),Random.Range(0,360),Random.Range(0,360)));
	}
}
