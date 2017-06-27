using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InfScore : MonoBehaviour {

	public int completed;
	public TextMesh com;

	void Awake(){
		if(!PlayerPrefs.HasKey("InfC")){
			PlayerPrefs.SetInt ("InfC", 0);
		}
	}

	void Update(){
		completed = PlayerPrefs.GetInt ("InfC");
		com.text = completed.ToString();
	}

	void OnTriggerEnter (Collider other){
		completed = PlayerPrefs.GetInt ("InfC") + 1;
		PlayerPrefs.SetInt ("InfC", completed);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
