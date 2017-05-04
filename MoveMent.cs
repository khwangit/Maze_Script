using UnityEngine;
using System.Collections;

public class MoveMent : MonoBehaviour {

	public GameObject player;
	public GameObject cam;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//player.transform.localRotation = cam.transform.localRotation;
		float yRot = cam.transform.rotation.y;

		Debug.Log (yRot);

		player.transform.rotation.eulerAngles = Quaternion.Euler (0, yRot, 0);

		//player.transform.rotation = yRot;
		//player.transform.Rotate(0, yRot, 0);

		//if (Input.touchCount == 1){

		//	player.transform.position = transform.position + Camera.main.transform.forward * 10f * Time.deltaTime;
		player.transform.position = transform.position + player.transform.forward * 10f * Time.deltaTime;

		//player.transform.position += new Vector3(0,0,1);
		//}

	}
}
