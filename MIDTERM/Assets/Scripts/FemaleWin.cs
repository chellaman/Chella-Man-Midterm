using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FemaleWin : MonoBehaviour {

	public GameObject femmeWinPrefab;
	public Transform FWinLocation;
	AudioSource win;

	void Start () {
		win = GetComponent<AudioSource> ();
		//StartCoroutine(wait());
	}


		void OnTriggerEnter (Collider other){
		if (other.gameObject.name == "Player") {
			Debug.Log ("hit");
			Instantiate (femmeWinPrefab, FWinLocation.position, FWinLocation.rotation);
			win.Play ();
		}
	}
//		IEnumerator wait()
//		{
//			print(Time.time);
//			yield return new WaitForSecondsRealtime(5);
//			print(Time.time);
//		}
		}

