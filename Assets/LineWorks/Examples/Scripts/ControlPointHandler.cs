using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using LineWorks;

namespace LineWorks.Examples {

public class ControlPointHandler : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler {

	public TentacleController tentacle;
	public LW_Fill fillStyle;
	public Color selectedColor = Color.red;
	public int pointIndex = 0;
	public int handleIndex = 0;

	private Color originalColor;

	private RectTransform m_Transform;

	private void Start() {
		m_Transform = transform as RectTransform;
		originalColor = fillStyle.color;
	}

	public void OnBeginDrag(PointerEventData eventData)	{
		fillStyle.color = selectedColor;
	}

	public void OnDrag(PointerEventData data) {
		Vector3 globalMousePos;
		if (RectTransformUtility.ScreenPointToWorldPointInRectangle(m_Transform, data.position, data.pressEventCamera, out globalMousePos)) {
			//m_Transform.position = globalMousePos;
			tentacle.OnDragPoint(pointIndex, handleIndex, globalMousePos);
		}
	}

	public void OnEndDrag(PointerEventData eventData) {
		fillStyle.color = originalColor;
	}
}

}
