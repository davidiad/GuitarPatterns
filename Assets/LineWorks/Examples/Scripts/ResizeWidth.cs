using UnityEngine;
using System.Collections;
using LineWorks;

namespace LineWorks.Examples {

public class ResizeWidth : MonoBehaviour {
	
	public Material material;
	
	public float frequency = 2f;
	public float magnitude = 10f;
	
	private float originalWidth;
	
	// Use this for initialization
	void Start () {
		originalWidth = material.GetFloat("_Width");
		
	}
	
	// Update is called once per frame
	void Update () {
		material.SetFloat("_Width", originalWidth + Mathf.PingPong(Time.time, frequency) * magnitude);
	}
}

}
