using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSound : MonoBehaviour {

	public AudioSource[] audio;
	public bool play = false;
	public GameObject obj;
    Test1 src;


	// Use this for initialization
	void Start () {
		src = obj.GetComponent<Test1> ();
	}
	
	// Update is called once per frame
	void Update () {
		src.WakeUp();
		if (Input.GetButtonDown ("Vertical")) {
			play = true;

			audio [0].Play();
			audio [1].Stop();

			}
		if (Input.GetButtonDown("Fire1")) {
			audio [2].Play();
		}
		if(Input.GetButtonUp("Vertical")){
			audio [0].Stop();
			audio [1].Play();
		}
	}

}
