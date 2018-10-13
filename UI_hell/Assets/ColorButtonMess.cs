using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButtonMess : MonoBehaviour {
	Image img;
	public float boost;
	// Use this for initialization
	void Start () {
		img = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		img.color = new Color(Mathf.PerlinNoise(0.1f,Time.time)*boost,Mathf.PerlinNoise(0.7f,Time.time)*boost,Mathf.PerlinNoise(1f,Time.time)*boost);
	}
}
