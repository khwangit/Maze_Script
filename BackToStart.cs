using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackToStart : MonoBehaviour {

	public void BTStark(){
		SceneManager.LoadScene (sceneBuildIndex:0);
	}

	public void GoToClassic(){
		SceneManager.LoadScene ("first", LoadSceneMode.Single);
	}

	public void GoToINF(){
		SceneManager.LoadScene (sceneBuildIndex:7);
	}

	public void GoToSaved(){
		int y = PlayerPrefs.GetInt ("cLevel");
		SceneManager.LoadScene (sceneBuildIndex: y);
	}

	public void DeleteAllPrefs(){
		PlayerPrefs.DeleteAll();
	}
}
