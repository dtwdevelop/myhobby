using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	private Animator anim;
	public float speed = 10;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody> ();
	}

	void Update(){
		
		//Anime();



	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		//rb.AddForce(transform.forward * speed);
	}


}
