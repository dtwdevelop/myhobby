using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraVM2 : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;
	public float smoothing = 5f;  


    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
    }

	void FixedUpdate ()
	{
		// Create a postion the camera is aiming for based on the offset from the target.
		Vector3 targetCamPos = player.transform.position + offset;

		// Smoothly interpolate between the camera's current position and it's target position.
		transform.position = targetCamPos;
	}
	

}
