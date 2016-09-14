using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LineWorks;

namespace LineWorks.Examples {

public class ImpactRings : MonoBehaviour {

	public float ringLifeSpan = 3f;
	public float ringMaxRadius = 1f;
	public Color[] colorArray;

	private Transform lineworkTransform;
	private LW_Canvas linework;
	private LW_Stroke masterStroke;

	void Start() {
		linework = LW_Canvas.Create(new GameObject(), "ImpactRings", false);
		//linework = LW_Canvas.Create(gameObject, "ImpactRings", false);
		linework.blendMode = BlendMode.AlphaBlend;
		linework.featureMode = FeatureMode.Advanced;
		linework.strokeDrawMode = StrokeDrawMode.Draw2D;
		linework.joinsAndCapsMode = JoinsAndCapsMode.Shader;
		linework.gradientsMode = GradientsMode.Vertex;
		linework.antiAliasingMode = AntiAliasingMode.On;

		lineworkTransform = linework.transform;
		lineworkTransform.position = new Vector3(0,0.1f,0);
		lineworkTransform.rotation = Quaternion.Euler(90,0,0);

		masterStroke = LW_Stroke.Create(Color.white, 0.05f);
		List<LW_ColorStop> colors = new List<LW_ColorStop>();
		for (int i=0; i<colorArray.Length; i++) colors.Add(new LW_ColorStop(colorArray[i], (float)i/(float)(colorArray.Length-1)));
		masterStroke.gradientColors = colors;
		masterStroke.paintMode = PaintMode.RadialGradient;
		masterStroke.gradientUnits = GradientUnits.userSpaceOnUse;
		masterStroke.presizeVBO = 100;
	}

	void OnCollisionEnter(Collision collision) {
		foreach (ContactPoint contact in collision.contacts) {
			CreateRing(lineworkTransform.InverseTransformPoint(contact.point));
		}
	}

	void CreateRing(Vector3 point) {
		if (linework != null) {
			LW_Circle circle = LW_Circle.Create(point, 0.01f);
			LW_Stroke stroke = masterStroke.Copy() as LW_Stroke;
			stroke.gradientStart = point;
			stroke.gradientEnd = point + Vector3.right * ringMaxRadius;
			linework.graphic.Add(circle);
			circle.styles.Add(stroke);

			StartCoroutine(DrawRing (circle, stroke));
		}
	}

	IEnumerator DrawRing (LW_Circle circle, LW_Stroke stroke) {
		float minRadius = circle.radius;
		float maxRadius = ringMaxRadius;
		float lifeSpan = 0;
		while (lifeSpan < ringLifeSpan) {
			float t = lifeSpan / ringLifeSpan;
			circle.radius = Mathf.Lerp(minRadius, maxRadius, t);
			lifeSpan += Time.deltaTime;
			yield return null;
		}
		if (linework != null) linework.graphic.Remove(circle);
	}
}

}
