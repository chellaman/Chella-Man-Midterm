using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideSkelTest : MonoBehaviour {

	public Vector3 teleportPoint;
	public Rigidbody rb;
	public int speed;
	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate() {
		rb.MovePosition(transform.position + transform.forward * Time.deltaTime * speed);
	}
}
