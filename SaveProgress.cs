using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SaveProgress : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		int y = SceneManager.GetActiveScene ().buildIndex;
		PlayerPrefs.SetInt ("cLevel", y);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
