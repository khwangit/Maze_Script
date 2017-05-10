using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	private bool stopped;
	public Rigidbody rb;
	public float coolDown;
	public TextMesh timerText;
	public GameObject sky;

	// Use this for initialization
	void Start () {
		coolDown = 30f;
		sky.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (coolDown <= 0f) {
			coolDown = 0f;
			sky.SetActive (true);
			timerText.text = "Jump Ready!";
		} else {
			coolDown -= Time.deltaTime;
			timerText.text = Mathf.RoundToInt (coolDown).ToString();
		}
	}

	public void clickToJump(){
		rb.velocity = new Vector3 (0f, 50f, 0f);
		coolDown = 30f;
		sky.SetActive(false);
	}
}
