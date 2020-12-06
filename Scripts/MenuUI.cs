using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuUI : MonoBehaviour {
    
	public float score;
	public Text money;
	public AudioMixer audioMixer;
	public float volume;
	public GameObject manager;
	private DataClass dc;
    
	void Start() {
		dc = manager.GetComponent<DataClass>();
		
		score = dc.getScore();
		money.text = score.ToString("0");
		
		volume = dc.getVolume();
		audioMixer.SetFloat("MusicVol", volume);
	}

	public void play() {
		SceneManager.LoadScene("Duo");
	}
	public void shop() {
		SceneManager.LoadScene("Shop");
	}
	public void quit() {
		Application.Quit();
	}
}
