using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
	
	public Text scoreT;
	public static float currentScore;
	public float savedscore;
	public GameObject Game;
	public GameObject gameOver;
	public GameObject manager;
	private DataClass dc;
	public static bool gameovertrigger;
	
	void Start() {
		dc = manager.GetComponent<DataClass>();
		gameovertrigger = false;
	}

	void Update() {
		if(gameovertrigger) {
			gameovertrigger = false;
			currentScore = PlayerMovement.score;
			scoreT.text = currentScore.ToString("0");
			
			Game.SetActive(false);
			gameOver.SetActive(true);
			UIControl.pause1();
			
			savedscore = dc.getScore();
			if(savedscore < currentScore) {
				dc.setScore(currentScore);
			}
		}
	}
}
