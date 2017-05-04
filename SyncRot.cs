using UnityEngine;
using System.Collections;

public class SyncRot : MonoBehaviour {

	public GameObject otherObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.rotation = Quaternion.Euler(otherObject.transform.rotation.eulerAngles);
		//transform.rotation = otherObject.transform.rotation;

		Vector3 newRot = new Vector3 (transform.eulerAngles.x, otherObject.transform.eulerAngles.y, transform.eulerAngles.z);
		transform.rotation = Quaternion.Euler (newRot);

		//transform.forward = new Vector3(otherObject.transform.forward.x, transform.forward.y, otherObject.transform.forward.z);
	}
}
