using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	
	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody rigidBody;
	private int count;

	void Start() {
		rigidBody = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText (); 
		winText.text = "";
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

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Pick up")) {
			other.gameObject.SetActive (false);
			count++;
			SetCountText ();
		}
	}

	void SetCountText(){
		countText.text = "Count: " + count.ToString(); 
		if (count >= 8) {
			winText.text = "You won!";
		}
	}
}
