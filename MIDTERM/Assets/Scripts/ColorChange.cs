using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("door").GetComponent<Skel_HitDoorMen> ().pee) {
			Renderer rend = GetComponent<Renderer> ();
			//rend.material.shader = Shader.Find ("BoySkel");
			rend.material.SetColor ("SkeletonMat", Color.blue);
		}
//		if (GameObject.Find ("femmeDoor").GetComponent<Skel_HitDoor> ().womanPee) {
//			
//			Renderer rend = GetComponent<Renderer> ();
//			//rend.material.shader = Shader.Find ("BoySkel");
//			rend.material.SetColor ("SkeletonMat", Color.red);
//		}
	}
}
