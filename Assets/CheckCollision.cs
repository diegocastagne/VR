using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour {

	public AudioClip musicToPlay;
	AudioSource musicPlayer;

	// Use this for initialization
	void Start () {
		musicPlayer = GetComponent<AudioSource> ();
		musicPlayer.clip = musicToPlay;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision collision){
		Debug.Log ("Collision Detected");
		//collision.gameObject.SetActive(false);
	}

	private void OnTriggerEnter(Collider other){
		Debug.Log ("Room Trigger Entered");
		musicPlayer.Play ();
	}

	private void OnTriggerExit(Collider other){
		Debug.Log ("Room Trigger Exited");
		musicPlayer.Stop ();
	}
}
