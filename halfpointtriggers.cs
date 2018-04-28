using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halfpointtriggers : MonoBehaviour {

	// Use this for initialization
	public GameObject labCompleteTrig;
	public GameObject halflapTrig;

	void OnTriggerEnter(){

		labCompleteTrig.SetActive(true);
		halflapTrig.SetActive(false);




	}
}
