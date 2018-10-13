using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialAdj : MonoBehaviour {
	Material mat;

	// Use this for initialization
	void Start () {
		mat = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	public void ChangeColor(){
		mat.color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));

	}
}
