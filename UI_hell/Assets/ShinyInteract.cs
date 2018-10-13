using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShinyInteract : MonoBehaviour {
	public GameObject particles;

	public void MakeParticles(){
		Instantiate(particles,transform.position,transform.rotation,this.transform);
	}
}
