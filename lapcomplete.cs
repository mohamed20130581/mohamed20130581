using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class lapcomplete : MonoBehaviour {

	// Use this for initialization
	public GameObject lapcompletetrig;
	public GameObject halflaptrig;


	public GameObject MinuteDisplay;
	public GameObject SecondDisplay;
	public GameObject  MiliDisplay;


	public GameObject LapTimeBox;

	public GameObject lapcounter;
	public int lapdone;

	public GameObject racefinish;

	void Update (){

		if (lapdone == 1) {
			racefinish.SetActive (true);
		}

	}

	void OnTriggerEnter() {
		lapdone += 1;
		if (laptimemanager.SecondCount <= 9) {

			SecondDisplay.GetComponent<Text> ().text = "0" + laptimemanager.SecondCount + ".";


		} else {
			SecondDisplay.GetComponent<Text> ().text = "" + laptimemanager.SecondCount + ".";
		}




		if (laptimemanager.MinuteCount <= 9) {

			MinuteDisplay.GetComponent<Text> ().text = "0" + laptimemanager.MinuteCount + ".";


		} else {
			MinuteDisplay.GetComponent<Text> ().text = "" + laptimemanager.MinuteCount + ".";
		}



		MiliDisplay.GetComponent<Text> ().text = "" + laptimemanager.MilliCount;


		PlayerPrefs.SetInt ("minutesave", laptimemanager.MinuteCount);
		PlayerPrefs.SetInt ("secsave", laptimemanager.SecondCount);
		PlayerPrefs.SetFloat ("millisave", laptimemanager.MilliCount);


		PlayerPrefs.SetInt ("minsave" , laptimemanager.MinuteCount  );
		PlayerPrefs.SetInt ("secsave" , laptimemanager.SecondCount );
		PlayerPrefs.SetFloat ("millisave" , laptimemanager.MilliCount  );

		laptimemanager.MinuteCount = 0;
		laptimemanager.SecondCount = 0;
		laptimemanager.MilliCount = 0;

		lapcounter.GetComponent<Text> ().text = "" + lapdone; 

		halflaptrig.SetActive (true);
		lapcompletetrig.SetActive (false);











	}

}
