using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static float sakil;
	public static bool paused;
	
	void Start() 
	{	
		sakil = 0;
		paused = false;
	}	
	
	void Update()
    {	
		paused = UIControl.paused;
		if(paused == false){
			transform.position = new Vector3(transform.position.x,transform.position.y+0.04f,transform.position.z);
			sakil = transform.position.y;
			if(Input.GetKey(KeyCode.RightArrow)) {
				transform.Rotate(new Vector3(0f,0f,-2f));
			}
			if(Input.GetKey(KeyCode.LeftArrow)) {
				transform.Rotate(new Vector3(0f,0f,2f));
			}
		}
    }
}