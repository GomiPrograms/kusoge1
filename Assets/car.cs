﻿using UnityEngine;
using System.Collections;

public class car : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			transform.position = new Vector3 (transform.position.x, transform.position.y + 1f, transform.position.z);
		}
	}
}
