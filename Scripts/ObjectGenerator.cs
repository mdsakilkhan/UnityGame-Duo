﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{		
	public float time;
	public int a;
	public int b;
	int shop;
	public GameObject[] objects;
	public GameObject[] sprites;
	public static bool paused;
		
	void Start()
	{
		LoadPlayer();
		Vector3 origin = new Vector3(0,0,0);
		Instantiate(sprites[shop],origin,Quaternion.identity);
	}
	
	void Update()
    {
		paused = UIControl.paused;
		if(paused == false){
			time += Time.deltaTime;
			if(time > 1f) {
				time = 0;
				b = Random.Range(-1,2);
				if (b == 0) {
					a = Random.Range(0,2);
					transform.position = new Vector3(b,transform.position.y,transform.position.z);
					GameObject instance = (GameObject)Instantiate(objects[a],transform.position,Quaternion.identity);
					Destroy(instance,5f);
				}
				if (b != 0) {
					a = Random.Range(0,objects.Length);
					transform.position = new Vector3(b,transform.position.y,transform.position.z);
					GameObject instance = (GameObject)Instantiate(objects[a],transform.position,Quaternion.identity);
					Destroy(instance,5f);
				}
			}			
		}
	}
	
	public void LoadPlayer() {
		PlayerData data = SaveSystem.LoadPlayer();
		shop = data.shop;
	}
}