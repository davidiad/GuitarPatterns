using UnityEngine;
using System.Collections;
using LineWorks;

namespace LineWorks.Examples {

public class ParallaxScroller : MonoBehaviour {
	
	public Transform theCamera;
	public Transform theScene;
	
	public Transform background;
	public Transform middleground;
	public Transform foreground;

	private LW_Canvas vectorGraphic;
	private LW_Graphic backgroundGraphic;
	private LW_Graphic middlegroundGraphic;
	private LW_Graphic foregroundGraphic;

	private Vector3 backgroundPosition;
	private Vector3 middlegroundPosition;
	private Vector3 foregroundPosition;
	
	public float backgroundParallax = 0;
	public float middlegroundParallax = 1;
	public float foregroundParallax = 2;
	
	// Use this for initialization
	void Start () {
		theScene = transform;
		vectorGraphic = GetComponent<LW_Canvas>();
		backgroundGraphic = vectorGraphic.graphic[0];
		middlegroundGraphic = vectorGraphic.graphic[1];
		foregroundGraphic = vectorGraphic.graphic[2];

		if (backgroundGraphic != null) backgroundPosition = backgroundGraphic.position;
		if (middlegroundGraphic != null) middlegroundPosition = middlegroundGraphic.position;
		if (foregroundGraphic != null) foregroundPosition = foregroundGraphic.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 difference =  -(theCamera.position-theScene.position);
		difference.z = 0;
		if (background != null) background.position = difference*backgroundParallax;
		if (middleground != null) middleground.position = difference*middlegroundParallax;
		if (foreground != null) foreground.position = difference*foregroundParallax;

		if (backgroundGraphic != null) backgroundGraphic.position = backgroundPosition + difference * backgroundParallax;
		if (middlegroundGraphic != null) middlegroundGraphic.position = middlegroundPosition + difference * middlegroundParallax;
		if (foregroundGraphic != null) foregroundGraphic.position = foregroundPosition + difference * foregroundParallax;

	}
}

}
