using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionMenu : MonoBehaviour
{
	public AudioMixer audioMixer;
	float volume;
    
	void Start() {
		LoadPlayer();
		audioMixer.SetFloat("volume", volume);
	}
	
	public void SetVolume (float volume) {
		PlayerPrefs.SetFloat("volume", volume);
		audioMixer.SetFloat("volume", volume);
	}
	
	public void SavePlayer() {
		SaveSystem.SavePlayer("volume");
	}
	public void LoadPlayer() {
		PlayerData data = SaveSystem.LoadPlayer();
		volume = data.volume;
	}
}