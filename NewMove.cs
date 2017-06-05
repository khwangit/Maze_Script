using UnityEngine;
using System.Collections;

public class NewMove : MonoBehaviour
{

	Transform mainCamera = null;

	public float speed = 10f;
	public bool onGround = false;

	void Start()
	{
		mainCamera = Camera.main.transform;
	}

	void Update()
	{
		if (Input.touchCount == 1 || Input.GetMouseButton (0)) {
			if(onGround){
				Vector3 direction = new Vector3(mainCamera.transform.forward.x, 0, mainCamera.transform.forward.z).normalized * speed * Time.deltaTime;
				Quaternion rotation = Quaternion.Euler(new Vector3(0, -transform.rotation.eulerAngles.y, 0));
				transform.Translate(rotation * direction);
			}
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