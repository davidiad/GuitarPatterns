using UnityEngine;
using System.Collections;

public class ChordShape {  //TODO: consider integrating with chord shapes

	public Vector2[] chordPoints;
	public Fretboard fretboard;

	public void SetPoints(Vector2[] _chordPoints) {
		chordPoints = _chordPoints;
	}
		
}

