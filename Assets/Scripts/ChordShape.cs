using UnityEngine;
using System.Collections;

public class ChordShape : MonoBehaviour {

	public Vector2[] chordPoints;
	public Fretboard fretboard;

	void Awake () {

	}

	void Start () {
//		Vector2 pt0 = new Vector2 (13f, 9.5f);
//		Vector2 pt1 = new Vector2 (13, 0f);
//		Vector2 pt2 = new Vector2 (8.6f, 1.9f);
//
//		chordPoints = new Vector2[] { pt0, pt1, pt2};
	}

	public void Init(Vector2[] _chordPoints) {
		chordPoints = _chordPoints;
	}
		
}

