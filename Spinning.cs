﻿using UnityEngine;
using System.Collections;

public class Spinning : MonoBehaviour {

	public float speed = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.back, speed * Time.deltaTime);

	}
}
