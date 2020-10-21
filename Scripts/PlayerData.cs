using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float sakil;	
	public int shop;
	public float volume;
	
	public PlayerData(string savewhat)
	{
		if (savewhat == "sakil") {
			sakil = PlayerPrefs.GetFloat("sakil", sakil);
		}
		if (savewhat == "shop") {
			shop = PlayerPrefs.GetInt("shop", shop);
		}		
		if (savewhat == "volume") {
			volume = PlayerPrefs.GetFloat("volume", volume);
		}
	}
}