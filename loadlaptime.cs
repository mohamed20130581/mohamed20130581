using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class loadlaptime : MonoBehaviour {

	public int mincount;
	public int seccount;
	public int millicount;
	public GameObject minDisplay; 
	public GameObject secDisplay; 
	public GameObject milliDisplay; 
	void Start () {

		mincount = PlayerPrefs.GetInt ("minsave");
		seccount = PlayerPrefs.GetInt ("secsave");
		millicount = PlayerPrefs.GetInt ("millisave");

		minDisplay.GetComponent<Text> ().text = "" + mincount + ":";
		secDisplay.GetComponent<Text> ().text = "" + seccount + ".";
		milliDisplay.GetComponent<Text> ().text = "" + millicount;
	}
	

}
