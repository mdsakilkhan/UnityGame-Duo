using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour {
	
    public static float score;
	public static bool paused;
	public Text money;
	
	void Update() {
		score = PlayerMovement.score;
		money.text = score.ToString("0");
	}
	
	public static void pause1() {
		paused = true;
		Time.timeScale = 0f;
	}
	public void pause() {
		paused = true;
		Time.timeScale = 0f;
	}
    public void resume() {
		paused = false;
		Time.timeScale = 1f;
	}
	
	public void menu() {
		resume();
		SceneManager.LoadScene("Menu");
	}
	public void replay() {
		resume();
		SceneManager.LoadScene("Duo");
	}
	public void quit() {
		Application.Quit();
	}
}
