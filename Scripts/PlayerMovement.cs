using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	
    public static float score;
	public static bool paused;
	public float speed;
	public float rotateSpeed;
	public bool mobile;
	
	void Start() {
		mobile = true; // false for pc control
		rotateSpeed = 250f;
		score = 0f;
		paused = false;
	}
	
	void Update() {	
		speed = CameraMovement.speed;
		paused = UIControl.paused;
		if(!paused){
			transform.position += Vector3.up * speed * Time.deltaTime;
			score = transform.position.y;
			
			if(mobile) { // touch control
 				if (Input.touchCount > 0) {
					var touch = Input.GetTouch(0);
					if (touch.position.x < Screen.width/2) {
						transform.Rotate(new Vector3(0f,0f,rotateSpeed * Time.deltaTime));
					}
					else {
						transform.Rotate(new Vector3(0f,0f,-rotateSpeed * Time.deltaTime));
					}
				}
			}
			else { // pc control
				if(Input.GetKey(KeyCode.RightArrow)) {
					transform.Rotate(new Vector3(0f,0f,-rotateSpeed * Time.deltaTime));
				}
				if(Input.GetKey(KeyCode.LeftArrow)) {
					transform.Rotate(new Vector3(0f,0f,rotateSpeed * Time.deltaTime));
				}
			}
		}
    }
}
