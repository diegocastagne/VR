using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {
	private Rigidbody rbd;

	[HideInInspector]
	public Hand m_ActiveHand = null;

	public void Start(){
		rbd = GetComponent<Rigidbody> ();
	}

	public void Update(){
		if(!transform.CompareTag("bola")){
			if (m_ActiveHand)
				rbd.isKinematic = false;
			else
				rbd.isKinematic = true;
		}
	}
}
