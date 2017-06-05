using UnityEngine;
using System.Collections;

public class MoveMent : MonoBehaviour {

	//public GameObject player;
	private float lockPos = 0f;
	public bool onGround = false;
	//public Rigidbody rb;
	//public GameObject cam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (onGround) {
			//if (Input.touchCount == 1 || Input.GetMouseButton (0)) {
				//transform.rotation = Quaternion.Euler (lockPos, transform.rotation.eulerAngles.y, lockPos);
				transform.position = transform.position + transform.forward * 10f * Time.deltaTime;
			//} else {
				//rb.velocity = new Vector3(0,0,0);
			//}
		} else {
			//rb.velocity = new Vector3(0,0,0);
		}
	}
		
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Ground")
		{
			onGround = true;
		}
	}

	void OnCollisionExit (Collision col){
		if(col.gameObject.tag == "Ground"){
			onGround = false;
		}
	}
}
