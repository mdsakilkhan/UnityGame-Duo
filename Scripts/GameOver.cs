using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
	public Text score;
	public static float sakil;
	public float highscore;
	public GameObject Game;
	public GameObject gameOver;
	public static bool gameovertrigger;
		
	void Start() 
	{
		gameovertrigger = false;
	}
	
	void Update() 
	{
		if(gameovertrigger) {
			gameovertrigger = false;
			sakil = PlayerMovement.sakil;
			score.text = sakil.ToString("0");
			
			Game.SetActive(false);
			gameOver.SetActive(true);
			UIControl.pause1();
			
			LoadPlayer();
			if(highscore < sakil) {
				PlayerPrefs.SetFloat("sakil", sakil);
				SavePlayer();
			}
		}
	}

	public void SavePlayer() {
		SaveSystem.SavePlayer("sakil");
	}
	public void LoadPlayer() {
		PlayerData data = SaveSystem.LoadPlayer();
		highscore = data.sakil;
	}
}