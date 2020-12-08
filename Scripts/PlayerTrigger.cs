using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour {
	
	void OnTriggerEnter2D() {
		GameOver.gameovertrigger = true;
	}
}
