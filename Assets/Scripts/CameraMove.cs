using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	Vector3 Camera1 = new Vector3(27.17879f, 4.373298f, -20.57001f);

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Time.time >= 3 && Time.time < 6) {
			transform.position = new Vector3 (27.17879f, 4.373298f, -20.57001f);
			transform.LookAt (Camera1);

		} 
	}
}