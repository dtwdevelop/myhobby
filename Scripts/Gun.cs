using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	Rigidbody rb ;
	public float speed = 5f;
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float sp = speed * Time.deltaTime;
		rb.AddForce(transform.forward *sp );
		StartCoroutine ("DetroyShoot");
	}

	IEnumerator  DetroyShoot(){

		yield return  new WaitForSeconds (8f);
		Destroy (gameObject);


	}
}
