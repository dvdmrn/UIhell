using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {
	public float timeToSelfDestruct;
	// Use this for initialization
	void Start () {
		Invoke("KillSelf",5f);
		
	}
	
	void KillSelf(){
		Destroy(gameObject);
	}
}
