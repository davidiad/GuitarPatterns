using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LineWorks;

namespace LineWorks.Examples {

public class DrawUI : MonoBehaviour {
		
	private LW_Canvas vectorCanvas;
	private LW_Polyline2D shape;
	
	private bool canDraw = false;
	private float deltaMinMove = 4f;
	private int maxPointsPerLine = 5000;
	private Vector2 lastPos;
	private float sqrMinMove;
	private List<Vector2> pointsList = new List<Vector2>();

	void Start () {
		vectorCanvas = LW_Canvas.Create(gameObject, "Drawing", true);
		vectorCanvas.featureMode = FeatureMode.Advanced;
		vectorCanvas.strokeDrawMode = StrokeDrawMode.Draw2D;
		vectorCanvas.joinsAndCapsMode = JoinsAndCapsMode.Shader;
		vectorCanvas.gradientsMode = GradientsMode.Vertex;
		vectorCanvas.antiAliasingMode = AntiAliasingMode.On;

		LW_Stroke stroke = LW_Stroke.Create(Color.red, 8);
		stroke.linecap = Linecap.Round;
		stroke.linejoin = Linejoin.Round;
		stroke.presizeVBO = 5000;

		vectorCanvas.graphic.styles.Add(stroke);
		
		sqrMinMove = deltaMinMove*deltaMinMove;
	}
	
	void Update () {
		if (Input.touchCount == 1) {		
			Touch touch = Input.GetTouch(0);
			Vector2 currPos = touch.position;
			currPos = new Vector3 (currPos.x - Screen.width/2f, currPos.y - Screen.height/2f, 0);
			if (touch.phase == TouchPhase.Began) {
				shape = LW_Polyline2D.Create(new Vector2[]{currPos});
				vectorCanvas.graphic.Add(shape);
				canDraw = true;
				lastPos = currPos;
			}
			else if (touch.phase == TouchPhase.Moved && (currPos - lastPos).sqrMagnitude > sqrMinMove && canDraw && pointsList.Count<maxPointsPerLine) {
				shape.Add(currPos);
				lastPos = currPos;
			}
	    }
		if (Input.touchCount == 0) {
			Vector2 currPos = Input.mousePosition;
			currPos = new Vector2 (currPos.x - Screen.width/2f, currPos.y - Screen.height/2f);
			if (Input.GetMouseButtonDown(0)) {
				shape = LW_Polyline2D.Create(new Vector2[]{currPos});
				vectorCanvas.graphic.Add(shape);
				canDraw = true;
				lastPos = currPos;
			}
			else if (Input.GetMouseButton(0) && (currPos - lastPos).sqrMagnitude > sqrMinMove && canDraw && pointsList.Count<maxPointsPerLine) {
				shape.Add(currPos);
				lastPos = currPos;
			}
		}
	}
}

}