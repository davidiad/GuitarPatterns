using UnityEngine;
using System.Collections;

namespace LineWorks.Examples {

public class OffsetTexture : MonoBehaviour {
	
	public Material material;
	public float timeToRepeat = 3f;
	private float offset = 0;
	
	// Update is called once per frame
	void Update () {
		if (material != null) {
			offset -= Time.deltaTime/timeToRepeat;
			material.SetTextureOffset("_MainTex", new Vector2(offset,0));
		}
	}
}

}
