﻿using UnityEngine;
using System.Collections;

public class DisappearFloor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter() {
		Destroy (gameObject);
		
	}
}
