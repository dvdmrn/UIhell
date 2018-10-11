using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIReactions : MonoBehaviour {

	Vector3 scale;

	// Use this for initialization
	void Start () {
	scale = transform.localScale; 
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void Rescale(Slider slider){
		float val = slider.value;
		transform.localScale = new Vector3(scale.x+val,scale.y+val,scale.z+val);
		print("rescaling with: "+scale);
	}

	public void Clicky(){
		transform.Rotate(new Vector3(Random.Range(0,360),Random.Range(0,360),Random.Range(0,360)));
	}
}
