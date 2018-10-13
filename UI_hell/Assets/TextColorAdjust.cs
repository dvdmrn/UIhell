using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextColorAdjust : MonoBehaviour {

	Text txt;

	// Use this for initialization
	void Start () {
		txt = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		txt.color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));
	}
}
