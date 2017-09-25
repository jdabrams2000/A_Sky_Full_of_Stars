using UnityEngine;
using System.Collections;

public class MoveCelestial : MonoBehaviour {

	public float speed;
	public float initX;
	public float initY;

	private float r;
	private float degrees;

	// Use this for initialization
	void Start () {
		r = Mathf.Sqrt(initX * initX + initY * initY);
		degrees = 0.0f;
		transform.position = new Vector3(initX, initY, 0.0f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		degrees = (speed * (degrees +1)) % 360.0f;
		transform.position = new Vector3(r * Mathf.Cos(degrees), r * Mathf.Sin(degrees), 0.0f);
	}
}
