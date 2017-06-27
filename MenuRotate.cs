using UnityEngine;
using System.Collections;

public class MenuRotate : MonoBehaviour {
	Transform mainCamera = null;

	private float speed = 0.1f;
	public GameObject pl;
	public GameObject cam;


	void Start()
	{
		mainCamera = Camera.main.transform;
	}

	void Update()
	{
		if(pl.transform.rotation != cam.transform.rotation){
			trytocatch ();
		}
	}

	IEnumerator trytocatch(){
		yield return new WaitForSeconds (5);
		pl.transform.rotation = cam.transform.rotation;
	}
		
}
