using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    private bool kill;
    private bool stopKill;
    private Animator animator;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("On");
        }
       
     }
}
