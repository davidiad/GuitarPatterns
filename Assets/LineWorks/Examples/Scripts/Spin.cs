using UnityEngine;
using System.Collections;

namespace LineWorks.Examples {

public class Spin : MonoBehaviour {
	
	public bool showGUI = false;
	public bool spinOnStartup = true;
	public float speed = 10;

	private Transform thisTransform;
	private bool isSpinning = false;

	void Start () {
		thisTransform = this.transform;
		isSpinning = spinOnStartup;
	}

	void Update () {
		if (isSpinning) {
			Vector3 euler = thisTransform.rotation.eulerAngles;
			thisTransform.rotation = Quaternion.Euler(0, euler.y+Time.deltaTime*speed, 0);
		}
	}
	
	void OnGUI() {
		if (showGUI) {
			if (GUI.Button(new Rect(Screen.width-70,10,60,20), "Spin")) {
				isSpinning = !isSpinning;
			}
		}
	}
}

}
