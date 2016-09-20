using UnityEngine;
using LineWorks;
using System.Collections.Generic;
public class LW_ExampleScript : MonoBehaviour {
	public LW_Canvas linework;
	private LW_Circle circle;
	private LW_Stroke stroke;
	private LW_Stroke strokeOutline;
	private LW_Polyline3D testLine;
	private LW_Polyline2D chordShapeLine;
	private LW_Polyline2D chordShapeLineOutline;
	private Material material;

	public ChordShape chordShape;

//	void Awake() {
//		chordShape = GameObject.FindGameObjectWithTag ("ChordShapes").GetComponent<ChordShape> ();
//	}

//	void Start () {
//		// Create the LineWorks Components and Scriptable Objects.
//		//linework = LW_Canvas.Create(gameObject, "MyFirstLineWork");
//		circle = LW_Circle.Create(Vector2.zero, 10f);
//		stroke = LW_Stroke.Create(Color.yellow, 1.6f);
//		strokeOutline = LW_Stroke.Create(Color.yellow, 2.2f);
//		Vector2 pt1 = new Vector2 (0f, 0f);
//		Vector2 pt2 = new Vector2 (5f, 6f);
//		Vector2 pt3 = new Vector2 (8f, -2f);
//		Vector2[] pts = new Vector2[] { pt1, pt2, pt3 };
//		testLine = LW_Polyline3D.Create (pts ,false);
//
//		chordShapeLine = LW_Polyline2D.Create (chordShape.chordPoints ,false);
//		chordShapeLineOutline = LW_Polyline2D.Create (chordShape.chordPoints ,false);
//
//		// Adjust the segmenetation to get a smoother looking line.
//		linework.segmentation = 20;
//		// If you want to use any of the advanced shader features you have to set featureMode to Advanced.
//		linework.featureMode = FeatureMode.Advanced;
//		// If you would like the stroke to be 3D. ie. always face the camera.
//		linework.strokeDrawMode = StrokeDrawMode.Draw3D;
//		// If you would like to have the shader provide anti-aliasing
//		linework.antiAliasingMode = AntiAliasingMode.On;
//		// It is recommended for 3D lines to use the 'Round' Linejoin.
//		linework.joinsAndCapsMode = JoinsAndCapsMode.Shader;
//		stroke.linejoin = Linejoin.Round;
//		stroke.linecap = Linecap.Round;
//		strokeOutline.linejoin = Linejoin.Round;
//		strokeOutline.linecap = Linecap.Round;
//		stroke.opacity = 0.3f;
//		strokeOutline.opacity = 0.5f;
//		// Apply the stroke to the circle and add the circle to the cavas.
//		circle.styles.Add(stroke);
//		//linework.graphic.Add(circle);
//		testLine.styles.Add (stroke);
//		//linework.graphic.Add (testLine);
//
//		chordShapeLine.styles.Add (stroke);
//		chordShapeLineOutline.styles.Add (strokeOutline);
//		linework.graphic.Add (chordShapeLine);
//		linework.graphic.Add (chordShapeLineOutline);
//	}
//	void Update () {
//		// While you can modify the width and color of the stroke directly on the LW_Stroke 
//		// element, it would cause a Mesh Rebuild that comes with a CPU performance cost. 
//		// By getting a reference to the auto-generated material and modify the material's 
//		// values, <strong>no CPU overhead</strong> will be required for rebuilding the Mesh. 
//		// This is great for dynamic situations where updating the Mesh every frame would 
//		// be unreasonable.
////		if (linework.materials != null && linework.materials.Count > 0) {
////			// We can use the first Material because with only one shape and one style, we 
////			// can be pretty sure there is only one Material. Don't confuse 'linework.materials' 
////			// with 'linework.material'. 'linework.materials' is a list of all the materials 
////			// applied to the MeshRenderer while 'linework.material' is used to override the 
////			// auto-generated materials.
////			material = linework.materials[0];
////			float t = Mathf.PingPong(Time.time, 1f);
////			// Ping-Pongs the stroke's Width between 2 and 4. This is multiplied by the 
////			// stroke width ie. stroke width(2f) * material width(2f to 4f) = final width;
////			material.SetFloat("_Width", Mathf.Lerp(2f, 2f, t));
////			// Ping-Pongs the stroke's Color between blue and red. This is multiplied by the 
////			// stroke color ie. stroke color(white) * material color(blue to red) = final color.
////			material.SetColor("_Color", Color.Lerp(Color.blue, Color.red, t));
////		}
//		// Spins the LineWork to show the 3D Lines. This is not a LineWorks thing.
//		//transform.localRotation = Quaternion.Euler(new Vector3(40f,40f,0) * Time.time);
//	}
}
