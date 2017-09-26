using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour {
	public float speed;
	public float speedUp;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float moveUp = Input.GetAxis ("Jump");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		Vector3 jump = new Vector3 (0.0f, moveUp, 0.0f);

		rb.AddForce (movement * speed);
		rb.AddForce (jump * speedUp);
	}

	void OnCollisionEnter (Collision other) {
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
		}
	}
}
