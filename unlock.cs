using UnityEngine;
using System.Collections;

public class unlock : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		PlayerPrefs.SetInt ("unlocked", 1);
	}
}
