﻿using UnityEngine;
using System.Collections;

public class KeyScript : MonoBehaviour {

	// Creating public transform variables for both players. These will be used for the key pickup and door unlock codes.
	public Transform Player1Pos;
	public Transform Player2Pos;


	// Creating public instance of one key. Left code for a second and third keys.  Uncomment those lines if they're needed.
	public KeyScript Switch;

	public bool SwitchIsOn = false;



	// Setting up AudioSources to be triggered when players perform certain actions
	public AudioSource SwitchSFX;
	public AudioClip KeyPickup;


	void Start () {
		
		SwitchIsOn = false;

	}
	
	// Update is called once per frame
	void Update () {

		// Code that allows Player 1 or Player 2 to pick up Key1.  The input buttons and distance to key are very subject to change.
		if (((Switch.transform.position - Player1Pos.position).magnitude < 2.5f) && Input.GetKeyDown (KeyCode.RightShift) && (SwitchIsOn = false)) {
			SwitchSFX.PlayOneShot (KeyPickup);
			SwitchIsOn = true;
			Debug.Log ("Switch is On");

		} else if (((Switch.transform.position - Player1Pos.position).magnitude < 2.5f) && Input.GetKeyDown (KeyCode.RightShift) && (SwitchIsOn = true)) {

			SwitchSFX.PlayOneShot (KeyPickup);
			SwitchIsOn = false;
			Debug.Log ("Switch is Off");
		}


		if (((Switch.transform.position - Player2Pos.position).magnitude < 2.5f) && Input.GetKeyDown (KeyCode.E) && (SwitchIsOn = false)) {

			SwitchSFX.PlayOneShot (KeyPickup);
			SwitchIsOn = true;
			Debug.Log ("Switch is On");

		} else if (((Switch.transform.position - Player2Pos.position).magnitude < 2.5f) && Input.GetKeyDown (KeyCode.E) && (SwitchIsOn = true)) {

			SwitchSFX.PlayOneShot (KeyPickup);
			SwitchIsOn = false;
			Debug.Log ("Switch is Off");
		}
	}
}
