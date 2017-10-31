using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeeForce : MonoBehaviour {

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		Debug.Log ("peeForce");
		rb = GetComponent<Rigidbody> ();
		rb.AddForce(transform.forward *100);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
