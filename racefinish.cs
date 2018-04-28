using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
public class racefinish : MonoBehaviour {

	public GameObject mycar;
	public GameObject finishcam;
	public GameObject viewmodes;
	public GameObject completetrig;

	void OnTriggerEnter(){
		//this.GetComponent<BoxCollider> ().enabled = false;
		mycar.SetActive (false);
		completetrig.SetActive (false);
		CarController.m_Topspeed = 0.0f;
		mycar.GetComponent<CarController> ().enabled = false;
		mycar.GetComponent<CarUserControl> ().enabled = false;
		mycar.SetActive (true);
		finishcam.SetActive (true);
		viewmodes.SetActive (false);

	}


	



}
