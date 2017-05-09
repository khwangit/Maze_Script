using UnityEngine;
using System.Collections;

public class MoveMent : MonoBehaviour {

	public GameObject player;
	private float lockPos = 0;
	//public GameObject cam;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//player.transform.rotation = cam.transform.rotation; spinnin like crazy
		//float yRot = cam.transform.rotation.y; 

		/*
		Vector3 newRot = new Vector3 (transform.eulerAngles.x, cam.transform.eulerAngles.y, transform.eulerAngles.z);
		player.transform.rotation = Quaternion.Euler (newRot);
		*/

		//Debug.Log (yRot);

		//player.transform.rotation.eulerAngles = Quaternion.Euler (0, yRot, 0);

		//player.transform.rotation.y = yRot;
		//player.transform.Rotate(0, yRot, 0);

		//if (Input.touchCount == 1){

		//	player.transform.position = transform.position + Camera.main.transform.forward * 10f * Time.deltaTime;
		player.transform.rotation = Quaternion.Euler(lockPos,transform.rotation.eulerAngles.y, lockPos);
		player.transform.position = transform.position + player.transform.forward * 10f * Time.deltaTime;

		//player.transform.position += new Vector3(0,0,1);
		//}

	}
}
