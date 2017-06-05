using UnityEngine;
using System.Collections;

public class LockRot : MonoBehaviour {



	public GameObject pl;
	private float lockPos = 0;
	public GameObject ca;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void FixedUpdate () {
		//pl.transform.rotation = Quaternion.Euler(lockPos, ca.transform.rotation.eulerAngles.y, lockPos);
		//spin like crazy

		pl.transform.rotation = ca.transform.rotation;
		pl.transform.position = ca.transform.position;
	}
}
