using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skel_HitDoor : MonoBehaviour {


	public GameObject firstText;
	public bool womanPee;
	public GameObject WomenSign;
	public GameObject femmePeePrefab;
	public Transform femmeLocation;
	int fPeeCount = 0;
	public GameObject skeleton;
	Rigidbody rb;



	void start(){
		rb = GetComponent<Rigidbody> ();
	}



//
//	 Update is called once per frame
	void OnTriggerEnter (Collider other){
		if (other.gameObject.name == "Player") {
			//skeleton.material.color = (Color.red);
		
			womanPee = true;
			gameObject.GetComponent<MeshRenderer>().enabled = false;
			gameObject.GetComponent<BoxCollider> ().enabled = false;

			Destroy (firstText);
			Destroy (WomenSign);
		}	
	}






}
