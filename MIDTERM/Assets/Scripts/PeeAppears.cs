using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PeeAppears : MonoBehaviour {

	public Transform peePrefab;
	public Transform PeeLocation;
	private static int peeCount = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("door").GetComponent<Skel_HitDoorMen> ().pee) {
			Instantiate (peePrefab, PeeLocation.position, PeeLocation.rotation);
			peeCount++;

			if (peeCount > 13) {
				Destroy (gameObject,2f);
			}
		}
	}
}
