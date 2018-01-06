using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class lvlmgr : MonoBehaviour {

	public void loadlevel(string name) {
        SceneManager.LoadScene(name);
	}
	
	public void quitGame() {
		Application.Quit();
	}
}
