using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	private bool stopped;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void clickToJump(){
		rb.velocity = new Vector3 (0f, 50f, 0f);
	}
}
