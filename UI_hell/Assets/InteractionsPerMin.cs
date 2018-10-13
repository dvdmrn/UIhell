using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionsPerMin : MonoBehaviour {

	public float ipm = 0;
	public float interactionDensity = 0;
	public int interactions = 0;
	public int minsElapsed = 0;

	public float decay = 2f;
	
	public float rollingAveOfInteractions = 0;
	
	// Use this for initialization
	void Start () {

		StartCoroutine("CalculateIPM");
		// StartCoroutine("CalculateID");

	}
	
	public void Interaction(){
		interactions += 1;
		interactionDensity += 1;
		print("Click event");
	}


	// public IEnumerator CalculateID(){
	// 	while(true){
	// 		yield return new WaitForSeconds(1f);
	// 		if(interactionDensity>0){
	// 			interactionDensity-=1;
	// 		}
	// 	}
	// }


	void FixedUpdate()
	{
		// decay Interaction Density
		if(interactionDensity>0){
			interactionDensity -= decay;
		}
	}


	IEnumerator CalculateIPM(){
		while(true){
			yield return new WaitForSeconds(10f);
			minsElapsed += 1;
			ipm = interactions/(float)minsElapsed;
			print("IPM: "+ipm);
		}
	}
}
