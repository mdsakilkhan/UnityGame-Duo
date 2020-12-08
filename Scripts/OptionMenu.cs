using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionMenu : MonoBehaviour {
	
	public AudioMixer audioMixer;
	public Slider slider;
	public GameObject manager;
	private DataClass dc;
	
 	void Start() {
		dc = manager.GetComponent<DataClass>();
		slider.value = dc.getVolume();
	}
	
	public void SetVolume(float volume) {
		audioMixer.SetFloat("MusicVol", volume);
		dc.setVolume(volume);	
	}
}
