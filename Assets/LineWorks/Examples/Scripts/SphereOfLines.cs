using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LineWorks;
using UnityEngine.UI;

namespace LineWorks.Examples {
	
public class SphereOfLines : MonoBehaviour {
	
	public Texture2D texture;
	
	private LW_Canvas vectorCanvas;
	private Material material;

	private LW_Polyline3D lines;
	private Vector3[] linePoints;

	public Text widthText;
	public Slider widthSlider;
	public Text colorText;
	public Slider colorSlider;
	public Text pointsText;
	public Slider pointsSlider;

	public Color[] colorArray;

	private float width = 5.0f;
	private float color = 2.7f;
	private int numberOfPoints = 500;
	private int lastNumberOfPoints = 500;
	private float ballRadius = 100;

	void Start () {
		vectorCanvas = LW_Canvas.Create(null, "BallOfLines", false);
		vectorCanvas.blendMode = BlendMode.AdditiveSoft;
		vectorCanvas.featureMode = FeatureMode.Advanced;
		vectorCanvas.strokeDrawMode = StrokeDrawMode.Draw3D;
		vectorCanvas.joinsAndCapsMode = JoinsAndCapsMode.Vertex;
		vectorCanvas.gradientsMode = GradientsMode.Vertex;
		vectorCanvas.antiAliasingMode = AntiAliasingMode.Off;
		vectorCanvas.mainTexture = texture;

		LW_Stroke stroke = LW_Stroke.Create(Color.white, 1f);
		stroke.linejoin = Linejoin.Break;

		vectorCanvas.graphic.styles.Add(stroke);
		lines = LW_Polyline3D.Create(new Vector3[0], false);
		vectorCanvas.graphic.Add(lines);

		SetWidth(width);
		SetColor(color);
		SetPoints(numberOfPoints);
		MakeLine(numberOfPoints);
	}

	void Update() {
		if (vectorCanvas != null && material == null && vectorCanvas.materials != null && vectorCanvas.materials.Count > 0) {
			material = vectorCanvas.materials[0];
			SetWidth(width);
			SetColor(color);
		}
	}

	private Color ColorAtValue(float value) {
		Color colorBefore = colorArray[Mathf.FloorToInt(value)];
		Color colorAfter = colorArray[Mathf.CeilToInt(value)];
		return Color.Lerp(colorBefore, colorAfter, value-Mathf.Floor(value));
	}
	private void MakeLine(int count) {
		linePoints = new Vector3[count];
		linePoints = new Vector3[count];
			for (int i = 0; i < linePoints.Length; i++) {
			linePoints[i] = Random.onUnitSphere * ballRadius;
		}
		lines.Set(linePoints, false);
	}

	public void SetWidth(float value) {
		width = value;
		if (widthSlider != null) widthSlider.value = width;
		if (widthText != null) widthText.text = "Shader Width: " + width;
		if (material != null) material.SetFloat("_Width", width);
	}
	public void SetColor(float value) {
		color = value;
		if (colorSlider != null) colorSlider.value = color;
		if (colorText != null) colorText.text = "Shader Color: " + color;
		if (material != null) material.SetColor("_Color", ColorAtValue(color));
	}
	public void SetPoints(float value) {
		numberOfPoints = (int)value;
		if (pointsSlider != null) pointsSlider.value = numberOfPoints;
		if (pointsText != null) pointsText.text = "Number Of Points: " + numberOfPoints;
	}

	public void Apply() {
		MakeLine(numberOfPoints);
		lastNumberOfPoints = numberOfPoints;
	}
	public void Cancel() {
		numberOfPoints = lastNumberOfPoints;
	}
}

}
