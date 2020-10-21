using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{	
	public static bool paused;
	
	void Start()
	{
		transform.position = new Vector3(transform.position.x,transform.position.y+2,transform.position.z);
    }
	
	void Update()
    {
		paused = UIControl.paused;
		if(paused == false){
			transform.position = new Vector3(transform.position.x,transform.position.y+0.04f,transform.position.z);
		}
	}
}