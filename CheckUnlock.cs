using UnityEngine;
using System.Collections;

public class CheckUnlock : MonoBehaviour {

	public GameObject GoInf;
	public GameObject NoInf;

	// Use this for initialization
	void Update () {
		if (PlayerPrefs.GetInt ("unlocked") == 1) {
			GoInf.SetActive (true);
			NoInf.SetActive (false);
		} else {
			GoInf.SetActive (false);
			NoInf.SetActive (true);
		}
	}
}
