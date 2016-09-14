using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LineWorks;
using UnityEngine.UI;

namespace LineWorks.Examples {

public class Simplify : MonoBehaviour {

	public LW_Canvas vectorCanvas;
	public Text verticesText;
	public Toggle advancedToggle;
	public Text segmentationText;
	public Slider segmentationSlider;
	public Text simplificationText;
	public Slider simplificationSlider;

	private int segmentation = 0;
	private float simplification = 0;
	private bool advanced = false;
	
	void Start() {
		if (vectorCanvas != null) {
			SetSegmentation((float)vectorCanvas.segmentation);
			SetSimplification(vectorCanvas.simplification);
			SetAdvancedFeatures(vectorCanvas.featureMode == FeatureMode.Advanced);
			if (verticesText != null) verticesText.text = "Vertex Count: " + vectorCanvas.vertexCount;
		}
	}

	void Update() {
		if (vectorCanvas != null && verticesText != null && !vectorCanvas.isDirty) {
			if (verticesText != null) verticesText.text = "Vertex Count: " + vectorCanvas.vertexCount;
		}
	}

	public void SetAdvancedFeatures(bool value) {
		advanced = value;
		if (advancedToggle != null) advancedToggle.enabled = advanced;
	}
		
	public void SetSegmentation(float value) {
		segmentation = (int)value;
		if (segmentationSlider != null) segmentationSlider.value = segmentation;
		if (segmentationText != null) segmentationText.text = "Segmentation: " + segmentation;
	}
	public void SetSimplification(float value) {
		simplification = value;
		if (simplificationSlider != null) simplificationSlider.value = simplification;
		if (simplificationText != null) simplificationText.text = "Simplification: " + simplification;
	}

	public void Apply() {
		vectorCanvas.simplification = simplification;
		vectorCanvas.segmentation = segmentation;
		vectorCanvas.featureMode = advanced ? FeatureMode.Advanced : FeatureMode.Simple;
	}
	public void Cancel() {
		SetSegmentation((float)vectorCanvas.segmentation);
		SetSimplification(vectorCanvas.simplification);
	}
}

}
