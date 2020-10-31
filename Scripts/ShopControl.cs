using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopControl : MonoBehaviour
{
	public GameObject camera;
	private Transform tf;
	public static int shop;
	
	void Start()
	{
		tf = camera.GetComponent<Transform>();
		LoadPlayer();
		tf.position = new Vector3(shop*1.5f,0,-10);
		transform.position = new Vector3(0,0,0);
    }
	
	void Update()
    {
        transform.position = new Vector3(transform.position.x,transform.position.y+0.04f,transform.position.z);
    }
	
	public void left() {
		if(tf.position.x != 0) {
			tf.position = new Vector3(tf.position.x-1.5f,tf.position.y,tf.position.z);
			shop--;
		}
	}	
	public void right() {
		if(tf.position.x != 9) {
			tf.position = new Vector3(tf.position.x+1.5f,tf.position.y,tf.position.z);
			shop++;
		}
	}
	
	public void menu() {
		PlayerPrefs.SetInt("shop", shop);		
		SavePlayer();
		SceneManager.LoadScene("Menu");
	}	
	public void SavePlayer() {
		SaveSystem.SavePlayer("shop");
	}
	public void LoadPlayer() {
		PlayerData data = SaveSystem.LoadPlayer();
		shop = data.shop;
	}
}