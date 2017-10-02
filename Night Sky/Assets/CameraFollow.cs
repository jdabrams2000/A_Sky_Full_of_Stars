using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;
	private Vector3 changePos;

	// Use this for initialization
	void Start () {

		offset = new Vector3 (player.transform.position.x, 0, player.transform.position.z);

	
	}
	
	// Update is called once per frame
	void Update () {
		changePos = new Vector3 (offset.x - player.transform.position.x, 0, offset.z - player.transform.position.z);
		transform.position = changePos;
		offset = new Vector3 (player.transform.position.x, 0, player.transform.position.z);
	}
}
