using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class MoveCharacter : MonoBehaviour {
	public float speed;
	public float speedUp;
	public Text countText;
	public Transform item;
	public float vol = 1f;
	public AudioClip clip;

	public Rigidbody rb;
	private int count;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
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

		if (count == 8) {
			transform.position = new Vector3 (150, -1280, -3287);
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			SpawnItem (item);
			SetCountText ();
		}
	}

	void SpawnItem(Transform item) {
		AudioSource.PlayClipAtPoint (clip, transform.position);
		item.position = new Vector3(Random.Range(-25,25),0,Random.Range(-25,25));
	}

	void SetCountText() {
		countText.text = "Count: " + count.ToString ();
	}
}
