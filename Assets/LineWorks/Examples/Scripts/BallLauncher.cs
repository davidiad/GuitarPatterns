using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LineWorks;

namespace LineWorks.Examples {

public class BallLauncher : MonoBehaviour {
	
	public float launchFrequency = 1f;
	public float ballLifeSpan = 3;
	public int numberOfPoints = 30;
	public GameObject ballPrefab;
	
	private float force = 5.0f;
	private float timer = 0;
	
	public Color[] colorArray;
	
	private Vector3 spawnPoint;
	
	private LW_Canvas linework;

	private float sqrMinMove;
	private float deltaMinMove = 0.01f;

	private Stack<GameObject> m_BallPool = new Stack<GameObject>();
	
	void Start () {
		spawnPoint = transform.position;
		Vector3[] points = new Vector3[0];
		for (int i=0; i<points.Length; i++) points[i] = spawnPoint;
		
		linework = LW_Canvas.Create(gameObject, "BallLauncher", false);
		linework.blendMode = BlendMode.AlphaBlend;
		linework.featureMode = FeatureMode.Advanced;
		linework.strokeDrawMode = StrokeDrawMode.Draw3D;
		linework.joinsAndCapsMode = JoinsAndCapsMode.Shader;
		linework.gradientsMode = GradientsMode.Vertex;
		linework.antiAliasingMode = AntiAliasingMode.On;

		LW_Stroke stroke = LW_Stroke.Create(Color.white, 1);
		List<LW_WidthStop> widths = new List<LW_WidthStop>();
		widths.Add(new LW_WidthStop(0.1f, 0f));
		widths.Add(new LW_WidthStop(0.0f, 1f));

		stroke.widths = widths;
		stroke.paintMode = PaintMode.LinearGradient;
		stroke.presizeVBO = 100;
		List<LW_ColorStop> colors = new List<LW_ColorStop>();
		for (int i=0; i<colorArray.Length; i++) colors.Add(new LW_ColorStop(colorArray[i], (float)i/(float)(colorArray.Length-1)));
		stroke.gradientColors = colors;
		stroke.linecap = Linecap.Round;
		stroke.linejoin = Linejoin.Round;

		linework.graphic.styles.Add(stroke);
	
		sqrMinMove = deltaMinMove*deltaMinMove;

		m_BallPool = new Stack<GameObject>();
		timer = launchFrequency;
	}
	void Update() {
		if (Input.GetButtonUp("Jump")) {
			LaunchBall();
		}
		timer += Time.deltaTime;
		if (timer > launchFrequency) {
			LaunchBall();
			timer = 0;
		}
	}
	
	void LaunchBall() {
		if (linework != null) {
			GameObject ball;
			if (m_BallPool.Count == 0) {
				ball = (GameObject)Instantiate(ballPrefab, transform.position, Quaternion.identity);
			}
			else {
				ball = m_BallPool.Pop();
				ball.SetActive(true);
				ball.transform.position = transform.position;
			}
			Vector3 launchVector = transform.up + new Vector3(Random.Range(-0.2f, 0.2f), 0, Random.Range(-0.2f, 0.2f));
			ball.GetComponent<Rigidbody>().AddForce (launchVector * (force*Random.Range(1f, 1.1f)), ForceMode.Impulse);
			LW_Polyline3D trail = LW_Polyline3D.Create(new Vector3[0], false);
			linework.graphic.Add(trail);
			StartCoroutine(DrawTrail (ball, trail));
		}
	}
	
	IEnumerator DrawTrail (GameObject ball, LW_Polyline3D trail) {
		Transform ballTransform = ball.transform;
		float lifeSpan = ballLifeSpan;
		Vector3 lastPos = Vector3.zero;
		while (lifeSpan > 0) {
			Vector3 currPos =  linework.gameObject.transform.InverseTransformPoint(ballTransform.position);
			if ((currPos - lastPos).sqrMagnitude > sqrMinMove) {
				ShiftAndAddPoint(currPos, trail);
				lastPos = currPos;
			}
			lifeSpan -= Time.deltaTime;
			yield return null;
		}
		ball.SetActive(false);
		m_BallPool.Push(ball);

		while (trail.points.Count > 0) {
			ShiftAndRemovePoint(trail);
			yield return null;
		}
		if (linework != null) linework.graphic.Remove(trail);
	}
	
	public void ShiftAndAddPoint(Vector3 point, LW_Polyline3D shape) {
		Vector3[] oldPoints = shape.points.ToArray();
		int newNumberOfPoints = Mathf.Clamp(oldPoints.Length+1, 1, numberOfPoints);
		Vector3[] newPoints = new Vector3[newNumberOfPoints];
		for (int i=0; i<oldPoints.Length; i++) {
			if (i < newNumberOfPoints-1) newPoints[i+1] = oldPoints[i];
		}
		newPoints[0] = point;
		shape.points = new List<Vector3>(newPoints);
	}
	public void ShiftAndRemovePoint(LW_Polyline3D shape) {
		Vector3[] oldPoints = shape.points.ToArray();
		int newNumberOfPoints = Mathf.Clamp(oldPoints.Length-1, 0, numberOfPoints);
		Vector3[] newPoints = new Vector3[newNumberOfPoints];
		for (int i=0; i<newNumberOfPoints; i++) {
			newPoints[i] = oldPoints[i];
		}
		shape.points = new List<Vector3>(newPoints);
	}
}

}
