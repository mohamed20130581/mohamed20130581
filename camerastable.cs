using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerastable : MonoBehaviour {

	// Use this for initialization
	public GameObject thecar; 
	public float carX;
	public float carY;
	public float carZ;
	// Update is called once per frame
	void Update () {
		carX = thecar.transform.eulerAngles.x;
		carY = thecar.transform.eulerAngles.y;
		carZ = thecar.transform.eulerAngles.z;

		transform.eulerAngles = new  Vector3 (carX-carX , carY, carZ-carZ );

	}
}
