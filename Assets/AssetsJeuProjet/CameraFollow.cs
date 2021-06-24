using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public Vector3 offset;
	public float smoothFactor = 10f;
	Camera cam;

	public void Start(){
		
		cam = Camera.main;
	}
	public void Update(){

		if (Input.GetKey (KeyCode.KeypadPlus))
			cam.orthographicSize -= .1f;
		if (Input.GetKey (KeyCode.KeypadMinus))
			cam.orthographicSize += .1f;
	}

	private void FixedUpdate()
	{
		Follow ();
	}

	void Follow(){
		
		Vector3 targetPosition = target.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp (transform.position, targetPosition, smoothFactor*Time.fixedDeltaTime);
		transform.position = targetPosition;
	}

	
}
