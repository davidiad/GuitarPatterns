using UnityEngine;
#if UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif
using System.Collections;

namespace LineWorks.Examples {
	
public class LevelLoader : MonoBehaviour {
	
	private int levelCount;
	private int loadedLevel;
	
	void Start () {
		#if UNITY_5_3_OR_NEWER
		levelCount = SceneManager.sceneCountInBuildSettings;
		loadedLevel = SceneManager.GetActiveScene().buildIndex;
		#else
		levelCount = Application.levelCount;
		loadedLevel = Application.loadedLevel;
		#endif
	}
	public void NextLevel () {
		if (levelCount > 1) {
			#if UNITY_5_3_OR_NEWER
			if (loadedLevel+1<levelCount) SceneManager.LoadScene(loadedLevel+1);
			else SceneManager.LoadScene(0);
			#else
			if (loadedLevel+1<levelCount) Application.LoadLevel(loadedLevel+1);
			else Application.LoadLevel(0);
			#endif
		}
		else Debug.Log("Add more than One Scene to the Build.");
	}
	public void PreviousLevel () {
		if (levelCount > 1) {
			#if UNITY_5_3_OR_NEWER
			if (loadedLevel>0) SceneManager.LoadScene(loadedLevel-1);
			else SceneManager.LoadScene(levelCount-1);
			#else
			if (loadedLevel>0) Application.LoadLevel(loadedLevel-1);
			else Application.LoadLevel(levelCount-1);
			#endif
		}
		else Debug.Log("Add more than One Scene to the Build.");
	}
}

}