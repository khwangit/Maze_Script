using UnityEngine;
using System.Collections;

public class LockRot : MonoBehaviour {

	public GameObject pl;
	private float lockPos = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		pl.transform.rotation = Quaternion.Euler(lockPos,transform.rotation.eulerAngles.y, lockPos);
	}
}
