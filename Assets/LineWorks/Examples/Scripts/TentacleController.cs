using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LineWorks;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace LineWorks.Examples {
	
public class TentacleController : MonoBehaviour {

	public class ControlPoint {
		public int pointIndex;
		public LW_Canvas handleInDot;
		public LW_Canvas handleInLine;
		public LW_Canvas handleOutDot;
		public LW_Canvas handleOutLine;
		public LW_Canvas positionDot;
	}

	public LW_Canvas vectorCanvas;
	public GameObject controlPointPrefab;
	public GameObject controlPointHandlePrefab;

	private LW_Path2D path;
	private List<ControlPoint> controlPoints;
	private List<LW_Point2D> points;

	private LW_Stroke tentacleStyle;
	private LW_Marker suctionCupStyle;
	private LW_Marker spotStyle1;
	private LW_Marker spotStyle2;
	private LW_Marker spotStyle3;

	private float orgTentacleWidth = 1;
	private Vector3 orgSizeOfSuctionCups = Vector3.one;
	private int orgNumOfSuctionCups = 0;
	private int orgNumOfSpots1 = 0;
	private int orgNumOfSpots2 = 0;
	private int orgNumOfSpots3 = 0;

	IEnumerator Start () {
		yield return null; //new WaitForSeconds(0.1f);
		if (vectorCanvas == null) vectorCanvas = GetComponent<LW_Canvas>();

		path = vectorCanvas.graphic[0] as LW_Path2D;
		points = path.points;

		tentacleStyle = path.styles[0] as LW_Stroke;
		suctionCupStyle = path.styles[1] as LW_Marker;
		spotStyle1 = path.styles[2] as LW_Marker;
		spotStyle2 = path.styles[3] as LW_Marker;
		spotStyle3 = path.styles[4] as LW_Marker;

		orgTentacleWidth = tentacleStyle.globalWidth;
		orgSizeOfSuctionCups = suctionCupStyle.scale;
		orgNumOfSuctionCups = suctionCupStyle.numberOfMarkers;
		orgNumOfSpots1 = spotStyle1.numberOfMarkers;
		orgNumOfSpots2 = spotStyle2.numberOfMarkers;
		orgNumOfSpots3 = spotStyle3.numberOfMarkers;

		controlPoints = new List<ControlPoint>();

		for (int i=0; i<points.Count; i++) {
			ControlPoint controlPoint = new ControlPoint();

			LW_Point2D point = points[i];
			if (point.hasHandleIn) {
				controlPoint.handleInLine = CreateControlPointLine(i, -1);
				controlPoint.handleInDot = CreateControlPointDot(i, -1);
			}
			if (point.hasHandleOut) {
				controlPoint.handleOutLine = CreateControlPointLine(i, 1);
				controlPoint.handleOutDot = CreateControlPointDot(i, 1);
			}
			controlPoint.positionDot = CreateControlPointDot(i, 0);

			controlPoints.Add(controlPoint);
		}
	}

	private LW_Canvas CreateControlPointDot(int pointIndex, int handleIndex) {
		LW_Point2D point = points[pointIndex];
		Vector3 position = (vectorCanvas.transform.localToWorldMatrix * vectorCanvas.scaler).MultiplyPoint3x4(point.position);
		float radius = 6f;
		Color color = Color.white;

		if (handleIndex < 0) {
			position += (vectorCanvas.scaler).MultiplyVector(point.handleIn);
			radius = 4f;
			color = Color.gray;
		}
		else if (handleIndex > 0) {
			position += (vectorCanvas.scaler).MultiplyVector(point.handleOut);
			radius = 4f;
			color = Color.gray;
		}
		//GameObject controlPointGO = new GameObject("ControlPoint " + pointIndex + " : " + handleIndex);
		//controlPointGO.transform.SetParent(vectorCanvas.transform);

		LW_Canvas canvas = LW_Canvas.Create(vectorCanvas.gameObject, "ControlPoint");
		LW_Circle circle = LW_Circle.Create(Vector3.zero, radius);
		LW_Fill fill = LW_Fill.Create(color);
		LW_Stroke stroke = LW_Stroke.Create(Color.black, 2f);

		circle.styles.Add(fill);
		circle.styles.Add(stroke);
		canvas.graphic.Add(circle);

		canvas.featureMode = FeatureMode.Advanced;
		canvas.joinsAndCapsMode = JoinsAndCapsMode.Shader;
		canvas.gradientsMode = GradientsMode.Shader;
		canvas.antiAliasingMode = AntiAliasingMode.On;

		canvas.transform.position = position;

		canvas.viewBox = new Rect(0,0,32,32);
		canvas.SetRectSizeToViewBox();

		ControlPointHandler cpHandler = canvas.gameObject.AddComponent<ControlPointHandler>();
		cpHandler.tentacle = this;
		cpHandler.pointIndex = pointIndex;
		cpHandler.handleIndex = handleIndex;
		cpHandler.fillStyle = fill;

		return canvas;
	}
	private LW_Canvas CreateControlPointLine(int pointIndex, int handleIndex) {
		LW_Point2D point = points[pointIndex];
		Vector3 start = (vectorCanvas.transform.localToWorldMatrix * vectorCanvas.scaler).MultiplyPoint3x4(point.position);
		Vector3 end = start;

		if (handleIndex < 0) {
			end += (vectorCanvas.scaler).MultiplyVector(point.handleIn);
		}
		else if (handleIndex > 0) {
			end += (vectorCanvas.scaler).MultiplyVector(point.handleOut);
		}
		LW_Canvas canvas = LW_Canvas.Create(vectorCanvas.gameObject, "ControlLine");
		LW_Line line = LW_Line.Create(start, end);
		LW_Stroke stroke = LW_Stroke.Create(Color.red, 2f);

		line.styles.Add(stroke);
		canvas.graphic.Add(line);

		canvas.featureMode = FeatureMode.Advanced;
		canvas.joinsAndCapsMode = JoinsAndCapsMode.Shader;
		canvas.gradientsMode = GradientsMode.Shader;
		canvas.antiAliasingMode = AntiAliasingMode.On;

		canvas.transform.position = Vector3.zero;

		//canvas.SetViewBoxToBounds();
		canvas.SetRectSizeToViewBox();
		//canvas.transform.position = start;

		return canvas;
	}

	public void OnDragPoint(int pointIndex, int handleIndex, Vector3 newWorldPosition) {
		LW_Point2D point = points[pointIndex];
		if (handleIndex < 0) {
			point.handleIn = ((Vector2)(vectorCanvas.transform.localToWorldMatrix * vectorCanvas.scaler).inverse.MultiplyPoint3x4(newWorldPosition)) - point.position;
		}
		else if (handleIndex > 0) {
			point.handleOut = ((Vector2)(vectorCanvas.transform.localToWorldMatrix * vectorCanvas.scaler).inverse.MultiplyPoint3x4(newWorldPosition)) - point.position;
		}
		else {
			point.position = (vectorCanvas.transform.localToWorldMatrix * vectorCanvas.scaler).inverse.MultiplyPoint3x4(newWorldPosition);
		}
		points[pointIndex] = point;

		ControlPoint controlPoint = controlPoints[pointIndex];
		Vector3 position = (vectorCanvas.transform.localToWorldMatrix * vectorCanvas.scaler).MultiplyPoint3x4(point.position);

		if (point.hasHandleIn) {
			Vector3 handleInPos = position + (vectorCanvas.transform.localToWorldMatrix * vectorCanvas.scaler).MultiplyVector(point.handleIn);
			//Debug.Log("HandleInPos: " + handleInPos + " newWorldPos: " + newWorldPosition);
			if (controlPoint.handleInDot != null) {
				controlPoint.handleInDot.transform.position = handleInPos;
			}
			if (controlPoint.handleInLine != null) {
				LW_Line line = controlPoint.handleInLine.graphic[0] as LW_Line;
				line.Set(position, handleInPos);
			}
		}
		if (point.hasHandleOut) {
			Vector3 handleOutPos = position + (vectorCanvas.transform.localToWorldMatrix * vectorCanvas.scaler).MultiplyVector(point.handleOut);
			if (controlPoint.handleOutDot != null) {
				controlPoint.handleOutDot.transform.position = handleOutPos;
			}
			if (controlPoint.handleOutLine != null) {
				LW_Line line = controlPoint.handleOutLine.graphic[0] as LW_Line;
				line.Set(position, handleOutPos);
			}
		}
		if (controlPoint.positionDot != null) controlPoint.positionDot.transform.position = position;

		path.points = points;
	}

	public void SetGlobalWidth(float multiplier) {
		tentacleStyle.globalWidth = orgTentacleWidth * multiplier;
	}
	public void SetNumOfSpots(float multiplier) {
		spotStyle1.numberOfMarkers = (int)(orgNumOfSpots1 * multiplier);
		spotStyle2.numberOfMarkers = (int)(orgNumOfSpots2 * multiplier);
		spotStyle3.numberOfMarkers = (int)(orgNumOfSpots3 * multiplier);
	}
	public void SetNumOfSuctionCups(float multiplier) {
		suctionCupStyle.numberOfMarkers = (int)(orgNumOfSuctionCups * multiplier);
	}
	public void SetSizeOfSuctionCups(float multiplier) {
		suctionCupStyle.scale = orgSizeOfSuctionCups * multiplier;
	}
}

}