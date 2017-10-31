using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skel_HitDoorMen : MonoBehaviour {

	Rigidbody rb;
	public GameObject firstText;
	public bool pee;
	public GameObject MenSign;
	AudioSource maleMusic;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		maleMusic = GetComponent<AudioSource> ();
	}


	void OnTriggerEnter (Collider other){
		if (other.gameObject.name == "Player") {
			pee = true;
			//Destroy (gameObject);
			gameObject.GetComponent<MeshRenderer> ().enabled = false;
			gameObject.GetComponent<BoxCollider> ().enabled = false;
			Destroy (firstText);
			Destroy (MenSign);
			maleMusic.Play ();
		}
	}
}


