using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CameraMovement : MonoBehaviour {
	
	public static bool paused;
	public static float speed = 5f;
	public AudioMixer audioMixer;
	public float volume;
	
	void Start() {
		PlayerData data = SaveSystem.LoadPlayer();
		volume = data.volume;
		audioMixer.SetFloat("MusicVol", volume);
		
		speed = 5f;
		transform.position = new Vector3(0f,transform.position.y+2,transform.position.z);
    }
	
	void Update() {
		speed += 0.05f * Time.deltaTime;
		paused = UIControl.paused;
		if(!paused){
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
	}
}
