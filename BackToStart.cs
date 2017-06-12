using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackToStart : MonoBehaviour {

	public void BTStark(){
		SceneManager.LoadScene (sceneBuildIndex:0);
	}
}
