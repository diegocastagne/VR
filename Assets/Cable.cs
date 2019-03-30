using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : MonoBehaviour {
	public GameObject conectorA;
	public GameObject conectorB;
	public GameObject enchufeA = null;
	public GameObject enchufeB = null;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (conectorA.GetComponent<Conexion> ().conectado)
			enchufeA = conectorA.GetComponent<Conexion> ().conectadoA;
		else
			enchufeA = null;
		if (conectorB.GetComponent<Conexion> ().conectado)
			enchufeB = conectorB.GetComponent<Conexion> ().conectadoA;
		else
			enchufeB = null;
	}
}
