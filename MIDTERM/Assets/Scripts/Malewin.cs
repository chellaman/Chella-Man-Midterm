using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Malewin : MonoBehaviour {

	public GameObject youWinPrefab;
	public Transform WinCollision;
	AudioSource music;
	AudioSource win;
	// Update is called once per frame
	void Update () {
		music = GameObject.Find("door").GetComponent<AudioSource>();
		win = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.name == "Player") {
			Debug.Log ("MaleWin");
			music.Stop ();
			Instantiate (youWinPrefab, WinCollision.position, WinCollision.rotation);
			win.Play ();
		}
	}
}

