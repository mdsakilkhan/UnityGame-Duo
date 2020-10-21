using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
	bool paused;
	
	void Update()
    {	
		paused = UIControl.paused;
		//make head not rotate
		if(paused == false){
			if(Input.GetKey(KeyCode.RightArrow)) {
				transform.Rotate(new Vector3(0f,0f,2f));
			}
			if(Input.GetKey(KeyCode.LeftArrow)) {
				transform.Rotate(new Vector3(0f,0f,-2f));
			}
		}
    }
	
	void OnTriggerEnter2D() {
		GameOver.gameovertrigger = true;
	}
}