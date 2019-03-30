using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conexion : MonoBehaviour {
	public bool conectado;
	public Material con;
	public Material des;
	public GameObject conectadoA;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	void OnTriggerEnter(Collider other){
		if (other.CompareTag("conector")||other.CompareTag("enchufe")){
			//gameManager.GetComponent<gameManager>.EnchufeB = true;
			conectado = true;
			GetComponent<Renderer> ().material = con;
			conectadoA = other.gameObject;
		}
	}

	void OnTriggerExit(Collider other){
		if (other.CompareTag("conector")||other.CompareTag("enchufe")){
			//gameManager.GetComponent<gameManager>.EnchufeB = true;
			conectado = false;
			GetComponent<Renderer> ().material = des;
			conectadoA = null;
		}
	}
}
