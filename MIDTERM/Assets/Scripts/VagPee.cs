using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VagPee : MonoBehaviour {

	GameObject femmePeePrefab;
	public Transform femmeLocation;
	float peeCount = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update(){
		if (GameObject.Find ("femmeDoor").GetComponent<Skel_HitDoor> ().womanPee) {
			Debug.Log ("vag pee");
			Instantiate (femmePeePrefab, femmeLocation.position, femmeLocation.rotation);
			peeCount++;

			if (peeCount > 2f) {
				Destroy (gameObject, 2f);
			}
		}
	}

}

