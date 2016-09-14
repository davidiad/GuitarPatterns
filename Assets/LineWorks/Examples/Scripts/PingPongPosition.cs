using UnityEngine;
using System.Collections;

namespace LineWorks.Examples {

public class PingPongPosition : MonoBehaviour {
	
	private Transform thisTransform;
	
	public float speed = 30;
	public Vector3 startPosition = new Vector3(-400,0,0);
	public Vector3 endPosition = new Vector3(400,0,0);
	
	// Use this for initialization
	void Start () {
		thisTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
		float t = Mathf.PingPong(Time.time*0.01f*speed, 1f);
		thisTransform.localPosition = Vector3.Slerp(startPosition, endPosition, t);
	}
}

}
