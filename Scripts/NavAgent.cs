using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavAgent : MonoBehaviour {
	public Transform target;
	public Transform car;
	public GameObject enemy;
	private UnityEngine.AI.NavMeshAgent agent;
	private Animator anim;
	private bool flag = false;
	// Use this for initialization
	void Start () {
		agent = enemy.GetComponent<UnityEngine.AI.NavMeshAgent>();
		agent.enabled = false;
		anim = enemy.GetComponent<Animator> ();

	
	}

	void Update(){
		if (flag) {
			StartCoroutine ("Anime");
		} 



	}
	
	// Update is called once per frame
	void OnTriggerExit(Collider other) {
		Debug.Log (other.tag);
		if (other.tag == "Kill") {
			agent.enabled = true;
			flag = true;
			anim.SetTrigger ("Walk");
			agent.SetDestination (target.position);

		} 

	}

	void OnTriggerEnter(Collider other) {
		
		if (other.name == "Home") {
			anim.SetTrigger("Walk");
		}

	}

	   IEnumerator Anime(){
		anim.SetTrigger("Walk");
		yield return new WaitForSeconds (30);
		anim.SetTrigger("Walk");
		agent.SetDestination (car.position);

		flag = false;
		Debug.Log  ("end ");
		}

}
