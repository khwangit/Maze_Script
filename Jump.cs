using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	private bool stopped;
	public Rigidbody rb;
	public float coolDown;
	public float resett;
	public TextMesh timerText;
	public GameObject sky;
	public float jumpforce = 30f;
	private bool onGround = false;

	public Transform other;

	// Use this for initialization
	void Awake () {
		coolDown = coolDown;
		sky.SetActive(false);
		timerText.text = Mathf.RoundToInt (coolDown).ToString();
	}
	
	// Update is called once per frame
	void Update () {
		if (coolDown <= 0f) {
			sky.SetActive (true);
			timerText.text = "Jump Ready!";
		} else if (onGround == true) {
			coolDown -= Time.deltaTime;
			timerText.text = Mathf.RoundToInt (coolDown).ToString();
		}


		if (other) {
			float dist = Vector3.Distance(other.position, transform.position);
			print("Distance to other: " + dist);
		}
	}

	public void clickToJump(){
		rb.velocity = new Vector3 (0f, jumpforce, 0f);
		coolDown = resett;
		timerText.text = coolDown.ToString ();
		sky.SetActive(false);
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
