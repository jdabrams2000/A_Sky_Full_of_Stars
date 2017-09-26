using UnityEngine;
using System.Collections;

public class MoveCelestial : MonoBehaviour {

	public float speed = 50f;
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(Vector3.zero, Vector3.back, speed * Time.deltaTime);
	}
}
