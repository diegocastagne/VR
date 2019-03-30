using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foco : MonoBehaviour {
	public bool encendido;
	public Material enc;
	public Material apa;
	// Use this for initialization
	void Start () {
		encendido = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(encendido)
			GetComponent<Renderer> ().material = enc;
		else
			GetComponent<Renderer> ().material = apa;
	}


}
