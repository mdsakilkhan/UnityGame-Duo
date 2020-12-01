using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData {

    public float score;	
	public int shop;
	public float volume;
	
	public PlayerData(DataClass dc) {
		score = dc.getScore();
		shop = dc.getShop();
		volume = dc.getVolume();
	}
}
