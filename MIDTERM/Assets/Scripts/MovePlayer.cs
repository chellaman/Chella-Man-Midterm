using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovePlayer : MonoBehaviour {

	public float speed;

	void Start(){
		speed = 7f;
	}
	
		private void Update() {

		float moveVert = Input.GetAxis ("Vertical") * speed;
		float moveHori = Input.GetAxis ("Horizontal") * speed;

		transform.Translate (moveHori, 0f, moveVert);

		}
}
