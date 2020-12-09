using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ShopControl : MonoBehaviour {
	
	public GameObject camera;
	private Transform tf;
	public static int shop;
	public AudioMixer audioMixer;
	public float volume;
	public GameObject manager;
	private DataClass dc;
	
	void Start() {
		dc = manager.GetComponent<DataClass>();
		shop = dc.getShop();		
		tf = camera.GetComponent<Transform>();
		tf.position = new Vector3(shop*1.5f,0,-10);
		transform.position = new Vector3(0,0,0);
		
		volume = dc.getVolume();
		audioMixer.SetFloat("MusicVol", volume);
    }
	
	void Update() {
        transform.position += Vector3.up * 5f * Time.deltaTime;
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
		dc.setShop(shop);
		SceneManager.LoadScene("Menu");
	}
}
