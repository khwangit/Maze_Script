using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	private bool stopped;
	public Rigidbody rb;
	public float coolDown;
	public TextMesh timerText;
	public GameObject sky;
	private bool onGround = false;

	// Use this for initialization
	void Awake () {
		coolDown = 30f;
		sky.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (coolDown <= 0f) {
			coolDown = 0f;
			sky.SetActive (true);
			timerText.text = "Jump Ready!";
		} else if (onGround == true) {
			coolDown -= Time.deltaTime;
			timerText.text = Mathf.RoundToInt (coolDown).ToString();
		}
	}

	public void clickToJump(){
		rb.velocity = new Vector3 (0f, 50f, 0f);
		coolDown = 30f;
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
