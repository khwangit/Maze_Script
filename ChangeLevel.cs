using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		SceneManager.LoadSceneAsync (SceneManager.GetActiveScene().buildIndex+1);
	}
}
