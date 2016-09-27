using UnityEngine;
using LineWorks;
using System.Collections.Generic;

public class VectorChord : MonoBehaviour {

	public LW_Canvas linework;
	private LW_Stroke stroke;
	private LW_Stroke strokeOutline;
	private LW_Polyline3D chordShapeLine;
	private LW_Polyline3D chordShapeLineOutline;
	// Create an array to hold the 5 chordshapes
	private LW_Polyline3D[] chordShapeLines;
	private LW_Polyline3D[] chordShapeOutlines;

	private Material material;
	public ChordShape chordShape;

	void Awake() {
		chordShapeLines = new LW_Polyline3D[5];
		chordShapeOutlines = new LW_Polyline3D[5];
	}

	void Start () {
			
		stroke = LW_Stroke.Create(Color.red, 1.4f);
		strokeOutline = LW_Stroke.Create(Color.white, 1.6f);
		chordShapeLine = LW_Polyline3D.Create (new Vector2[0] ,false);
		chordShapeLineOutline = LW_Polyline3D.Create (new Vector2[0] ,false);


		stroke.verticalOffset = 0.1f;
		// Adjust the segmenetation to get a smoother looking line.
		linework.segmentation = 20;
		// If you want to use any of the advanced shader features you have to set featureMode to Advanced.
		linework.featureMode = FeatureMode.Advanced;
		// If you would like the stroke to be 3D. ie. always face the camera.
		linework.strokeDrawMode = StrokeDrawMode.Draw2D;
		// If you would like to have the shader provide anti-aliasing
		linework.antiAliasingMode = AntiAliasingMode.On;
		// It is recommended for 3D lines to use the 'Round' Linejoin.
		linework.joinsAndCapsMode = JoinsAndCapsMode.Shader;
		stroke.linejoin = Linejoin.Round;
		stroke.linecap = Linecap.Round;
		strokeOutline.linejoin = Linejoin.Round;
		strokeOutline.linecap = Linecap.Round;
		stroke.opacity = 1.0f;
		strokeOutline.opacity = 1.0f;
			
		for (int i = 0; i < 5; i++) { // creating a chordshape for each of the 5 CAGED shapes
			chordShapeLines[i] = LW_Polyline3D.Create (new Vector2[0] ,false);
			chordShapeLines[i].styles.Add (stroke);
			linework.graphic.Add (chordShapeLines [i]);

			chordShapeOutlines[i] = LW_Polyline3D.Create (new Vector2[0] ,false);
			chordShapeOutlines[i].styles.Add (strokeOutline);
			linework.graphic.Add (chordShapeOutlines [i]);
		}



			chordShapeLine.styles.Add (stroke);
			chordShapeLineOutline.styles.Add (strokeOutline);
			linework.graphic.Add (chordShapeLine);
			linework.graphic.Add (chordShapeLineOutline);


		}


	public void DrawChord(ChordShape _chordShape, int _index) {

		chordShapeLines [_index].Set (_chordShape.chordPoints, false);
		chordShapeOutlines [_index].Set (_chordShape.chordPoints, false);

	}
}

