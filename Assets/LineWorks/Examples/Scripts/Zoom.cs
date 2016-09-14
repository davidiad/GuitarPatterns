using UnityEngine;
using System.Collections;

namespace LineWorks.Examples {

public class Zoom : MonoBehaviour {
	
	public Transform targetTransform;

	private Transform cameraTransform;
	private float distance;
	private float zoomSpeed = 2.0f;
	private float scale = 1;

	void Start () {
		cameraTransform = this.transform;
	}

	void Update () {
		distance = (cameraTransform.position-targetTransform.position).magnitude;
		
		float rad =  (cameraTransform.GetComponent<Camera>().fieldOfView/2) * Mathf.Deg2Rad;
		scale = (distance * Mathf.Tan(rad) * 2)/cameraTransform.GetComponent<Camera>().pixelHeight;

		if (Input.GetAxis("Mouse ScrollWheel") != 0) {
			ZoomCamera(Input.GetAxis("Mouse ScrollWheel") * -200.0f);
		}
	}
	
	void ZoomCamera (float delta){
		distance = distance + delta * zoomSpeed * scale;
		if (distance < 0.5f) distance = 0.5f;
		cameraTransform.position = cameraTransform.rotation * new Vector3(0.0f, 0.0f, -distance) + targetTransform.position;
	}
}

}
