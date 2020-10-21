using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public float highscore;
	public Text money;
	
	void Start()
    {
		LoadPlayer();
		money.text = highscore.ToString("0");
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
	
	public void LoadPlayer() {
		PlayerData data = SaveSystem.LoadPlayer();
		highscore = data.sakil;
	}
}