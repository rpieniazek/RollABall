using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Rigidbody rigidBody;
	public float speed;

	void Start() {
		rigidBody = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		float moveHorizont = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizont, 0, moveVertical);
		rigidBody.AddForce (movement * speed);

	}
}
