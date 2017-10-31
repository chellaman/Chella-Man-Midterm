using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMoveCam : MonoBehaviour {

	private float m_yRot;
	private float m_xRot;
	private Vector3 m_rotation;
//	private Vector3 m_cameraRotation;
	public float m_lookSensitivity = 3.0f;
	Camera mycam;

	// Use this for initialization
	void Start () {
		mycam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		m_yRot = Input.GetAxisRaw("Mouse X");
//		m_rotation = new Vector3(0, m_yRot, 0) * m_lookSensitivity;

		m_xRot = Input.GetAxisRaw("Mouse Y");
//		m_cameraRotation = new Vector3(m_xRot, 0, 0) * m_lookSensitivity;

		m_rotation = new Vector3 (m_xRot, m_yRot, 0)* m_lookSensitivity;

		mycam.transform.rotation = Quaternion.Euler (m_rotation);

	}
}
