using UnityEngine;
using System.Collections;
using LineWorks;

namespace LineWorks.Examples {
	
public class ResizeRect : MonoBehaviour {
	
	public LW_Canvas manager;
	public LW_Group group;
	
	public float frequency = 2f;
	public float magnitude = 10f;
	
	private LW_Rectangle shape;
	private float originalWidth;
	
	// Use this for initialization
	void Start () {
		group = manager.graphic as LW_Group;
		shape = group[0] as LW_Rectangle;
		originalWidth = shape.width;
		
	}
	
	// Update is called once per frame
	void Update () {
		shape.width = originalWidth + Mathf.PingPong(Time.time, frequency) * magnitude;
	}
}

}
