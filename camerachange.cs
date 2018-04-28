using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerachange : MonoBehaviour {

	public GameObject normalcam;
	public GameObject farcam;
	public GameObject fpcam;
	public int cammode; //whic camera in i used recently

	void Update () {

		if (Input.GetButtonDown ("viewmode")) {

			if (cammode == 3) {
				cammode = 0;

			} else {
				cammode += 1;

			}

			StartCoroutine (ModeChange ());


		}

	}


	IEnumerator ModeChange () {

		yield return new WaitForSeconds (0.01f);
		if (cammode == 0) {
			normalcam.SetActive (true);
			fpcam.SetActive (false);
		}

		if (cammode == 1) {
			farcam.SetActive (true);
			normalcam.SetActive (false);
		}

		if (cammode == 2) {
			fpcam.SetActive (true);
			farcam.SetActive (false);
		}



	}








}
