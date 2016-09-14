using UnityEngine;
using System.Collections;

namespace LineWorks.Examples {
	
public class Ball2DSpawner : MonoBehaviour {

	public GameObject ballPrefab;

	void Update () {
		if (ballPrefab != null && Input.GetButtonDown("Fire1")) {
			GameObject go = Instantiate(ballPrefab);
			Destroy(go, 10f);
		}
	}
}

}
