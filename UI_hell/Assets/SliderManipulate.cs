using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.EventSystems;// Required when using Event data.

public class SliderManipulate : MonoBehaviour, IPointerDownHandler// required interface when using the OnPointerDown method.
{	
	public InteractionsPerMin ipm;
	Slider slider;
	bool clicked;
	float resetTime = 1f;
	float clickTime;
	void Start(){
		slider = GetComponent<Slider>();
		clicked = false;
	}

    //Do this when the mouse is clicked over the selectable object this script is attached to.
    public void OnPointerDown (PointerEventData eventData) 
    {
		ipm.Interaction();
		clicked = true;
	}
	// void Update () {
	// 	if(!clicked){
	// 		slider.value = Mathf.PerlinNoise(0.99f,Time.time);
	// 		clickTime = Time.time;
	// 	}
	// 	if(clicked && (Time.time-clickTime > resetTime)){
	// 		clicked = false;
	// 	}
		
	// }
}

