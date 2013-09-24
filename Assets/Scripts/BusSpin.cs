using UnityEngine;
using System.Collections;

public class BusSpin : MonoBehaviour {
	
	public float rotateSpeed = 900f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
		{
		if ( Time.time > 20f && Time.time < 80f) {
		transform.Rotate( 0f, rotateSpeed, 0f ); 
	}
}
}
