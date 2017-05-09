using UnityEngine;
using System.Collections;

public class MoveMent : MonoBehaviour {

	//public GameObject player;
	private float lockPos = 0;
	//public GameObject cam;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//if (Input.touchCount == 1){
		transform.rotation = Quaternion.Euler(lockPos,transform.rotation.eulerAngles.y, lockPos);
		transform.position = transform.position + transform.forward * 10f * Time.deltaTime;
		//}

	}
}
