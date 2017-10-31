using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class femmePeeForce : MonoBehaviour {


	public Transform femmeLocation;
	public GameObject femmePeePrefab;
	private static int fPeeCount = 0;
	//AudioSource femaleMusic;

	// Use this for initialization
	void Start () {
//		rb = GetComponent<Rigidbody> ();
		//femaleMusic = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("femmeDoor").GetComponent<Skel_HitDoor> ().womanPee) {

			//femaleMusic.Play ();

			Instantiate (femmePeePrefab, femmeLocation.position, femmeLocation.rotation);
			fPeeCount++;
			Debug.Log ("F Pee Debug");
			if (fPeeCount > 25) {
				Destroy (this.gameObject);
			}

		}
	}
}
