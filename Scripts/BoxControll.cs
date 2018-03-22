using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControll : MonoBehaviour {
	public float speed ;
	public float angle;
	public Camera cam;
	public GameObject box;
	private Vector3  vector;
	private bool status =true;
	private Rigidbody rb;
	private float rot;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		float  vertical = Input.GetAxis ("Vertical");
		if(Input.GetKeyDown(KeyCode.E)){
			  status = false;
			}
		vector = cam.transform.position - gameObject.transform.position;

	}

	void FixedUpdate(){
		if (Input.GetKeyDown (KeyCode.Q)) {
			
			Instantiate (box.gameObject, transform.position , transform.rotation);
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			rb.velocity = transform.forward * speed;

		}
		if (Input.GetKeyDown (KeyCode.S)) {
			rb.velocity = transform.forward * -speed;
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			rb.velocity = transform.up * -speed;
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			rb.velocity = transform.up * speed;
		}
		rot += Time.deltaTime * angle;
		//transform.rotation = Quaternion.Euler (0f,0f ,rot );
		cam.transform.LookAt(cam.transform.position);

    }

	void OnTriggerEnter(Collider box){
		
		Destroy (box.gameObject);
	}

}