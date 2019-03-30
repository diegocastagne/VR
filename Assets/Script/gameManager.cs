using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

	//GameObject[] enchufes;
	GameObject[] focos;
	GameObject[] cables;
	// Use this for initialization
	void Start () {
		//enchufes = GameObject.FindGameObjectsWithTag ("enchufe");
		focos = GameObject.FindGameObjectsWithTag ("foco");
		cables = GameObject.FindGameObjectsWithTag ("cable");
	}
	
	// Update is called once per frame
	void Update () {
		bool prueba1=false, prueba2=false, flag = false;
		foreach (GameObject cab in cables) {
			if (cab.GetComponent<Cable> ().enchufeA != null && cab.GetComponent<Cable> ().enchufeB != null) {
				if (cab.GetComponent<Cable> ().enchufeA.name == "Enchufe A" && cab.GetComponent<Cable> ().enchufeB.name == "Enchufe C") {
					prueba1 = true;
				}
				if (cab.GetComponent<Cable> ().enchufeA.name == "Enchufe C" && cab.GetComponent<Cable> ().enchufeB.name == "Enchufe A") {
					prueba1 = true;
				}
				if (cab.GetComponent<Cable> ().enchufeA.name == "Enchufe B" && cab.GetComponent<Cable> ().enchufeB.name == "Enchufe D") {
					prueba2 = true;
				}
				if (cab.GetComponent<Cable> ().enchufeA.name == "Enchufe D" && cab.GetComponent<Cable> ().enchufeB.name == "Enchufe B") {
					prueba2 = true;
				}
			} 
			if (prueba1 && prueba2)
				flag = true;
		}
		if (flag) {
			foreach (GameObject foc in focos)
				foc.GetComponent<Foco> ().encendido = true;
		} else {
			foreach (GameObject foc in focos)
				foc.GetComponent<Foco> ().encendido = false;
		}
	}
}
