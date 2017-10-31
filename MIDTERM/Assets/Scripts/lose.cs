using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lose : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Start LOSE");
	}

		
	void OnTriggerEnter (Collider col){
		if (col.gameObject.name == "Player") {
			Debug.Log ("LOSE");
			//Restart Game
			Application.LoadLevel ("MaleScene");  
		}
	}

}
