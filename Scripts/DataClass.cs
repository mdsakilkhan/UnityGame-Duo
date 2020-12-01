using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataClass : MonoBehaviour {

	public static float score;	
	public static int shop;
	public static float volume;
	
	void Start() {
		PlayerData data = SaveSystem.LoadPlayer();
		score = data.score;
		shop = data.shop;
		volume = data.volume;
	}
	
	public float getScore() {
		return score;
	}
	
	public int getShop() {
		return shop;
	}
	
	public float getVolume() {
		return volume;
	}
	
	public void setScore(float data) {
		score = data;
		SaveSystem.SavePlayer(this);
	}
	
	public void setShop(int data) {
		shop = data;
		SaveSystem.SavePlayer(this);
	}
	
	public void setVolume(float data) {
		volume = data;
		SaveSystem.SavePlayer(this);
	}
}