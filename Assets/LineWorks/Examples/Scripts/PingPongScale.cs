using UnityEngine;
using System.Collections;

namespace LineWorks.Examples {

public class PingPongScale : MonoBehaviour {
	
	private Transform thisTransform;
	
	public float speed = 30;
	public Vector3 startScale = Vector3.one * 0.25f;
	public Vector3 endScale = Vector3.one * 1.0f;
	
	// Use this for initialization
	void Start () {
		thisTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
		float t = Mathf.PingPong(Time.time*0.01f*speed, 1f);
		thisTransform.localScale = Vector3.Slerp(startScale, endScale, t);
	}
}

}
