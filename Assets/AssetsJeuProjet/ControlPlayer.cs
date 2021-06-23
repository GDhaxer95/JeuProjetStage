using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour {
	public float doubleTapThreshold = 0.5f;
	public float impulse = 10.0f;
	public float speed = 1.0f;
	private Rigidbody2D _body;
	private Vector2 _inputs = Vector2.zero;
	private Vector2 _impulses = Vector2.zero;
	private float _timeStampLeft = 0f, _timeStampRight = 0f;
	private bool _isOnGround = false;
	void OnCollisionEnter2D(Collision2D coll) // We check whether a collision has been detected between the player and other objects using the built-in function OnCollisionEnter2D.
	{
		if (coll.collider.tag == "ground") //If the other object has a tag called ground then the variable called isOnground is set to true.
			_isOnGround = true;
		else //Otherwise, this variable is set to false.
			_isOnGround = false; 
	}

	// Use this for initialization
	void Start () {
		_body = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {

		_inputs = Vector2.zero;
		_inputs.x = Input.GetAxis ("Horizontal");
		//_inputs.y = Input.GetAxis ("Vertical");
		_impulses = Vector2.zero;
		if (Input.GetKeyDown (KeyCode.LeftArrow))
		{
			if (Time.time - _timeStampLeft < doubleTapThreshold) 
			{
				_impulses.x = -impulse;
			}
			_timeStampLeft = Time.time;

		} 

		else if (Input.GetKeyDown (KeyCode.RightArrow)) 
		{
			if (Time.time - _timeStampRight < doubleTapThreshold) 
			{
				_impulses.x = impulse;
			}
			_timeStampRight = Time.time;
		}
		//else if (Input.GetKeyDown (KeyCode.RightShift)) //key for shooting//
		
	}

	void FixedUpdate (){

		_body.MovePosition (_body.position + _inputs * speed * Time.fixedDeltaTime);

		if (_impulses != Vector2.zero) {
			_body.AddForce (_impulses);
			_impulses = Vector2.zero;
		}

	}
}
