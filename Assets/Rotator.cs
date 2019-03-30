using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	public float amountToRotate;

	// Use this for initialization
	void Start () {
		if (amountToRotate == 0) {
			amountToRotate = 0.5f;	
		}
	}
	
	// Update is called once per frame
	void Update () {
		RotateNow (amountToRotate);
	}

	void RotateNow(float toRotate){
		gameObject.transform.Rotate(new Vector3(0,toRotate,0));
		
	}
}
