﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChordShapes : MonoBehaviour {

	public ChordShape[] chordShapes;
	public int rootNote;
	public GameObject fretboardObject; // need the fretboard to access the strings which hold the notes
	private Fretboard fretboard;

	private Vector2[][] CAGED_shapeInfo;

	void Awake () {
		chordShapes = new ChordShape[15];
		fretboard = fretboardObject.GetComponent<Fretboard> ();
	}

	void Start () {
		for (int i = 0; i < chordShapes.Length; i++) {
			chordShapes [i] = new ChordShape ();
		}

		// Set the values that define the chord shapes
		Vector2[] C_shapeInfo = new Vector2[4] { new Vector2(1,8), new Vector2(3,9), new Vector2(4,10), new Vector2(5,10) };
		Vector2[] A_shapeInfo = new Vector2[3] { new Vector2(1,0), new Vector2(2,0), new Vector2(3,0) };
		Vector2[] G_shapeInfo = new Vector2[4] { new Vector2(0,3), new Vector2(1,3), new Vector2(5,3), new Vector2(4,2) };
		Vector2[] E_shapeInfo = new Vector2[5] { new Vector2(0,3), new Vector2(1,3), new Vector2(2,4), new Vector2(3,5), new Vector2(4,5) };
		Vector2[] D_shapeInfo = new Vector2[4] { new Vector2(0,7), new Vector2(1,8), new Vector2 (2, 7), new Vector2 (5, 7) };

		CAGED_shapeInfo = new Vector2[5][] { C_shapeInfo, A_shapeInfo, G_shapeInfo, E_shapeInfo, D_shapeInfo };
	}

	public Vector2[][] GetChordShapes(int _rootFret) {
		// Start with A shape for G chord. _rootFret = 0 (on the 3rd string)
		Vector2[][] chordPaths = new Vector2[15][];

		for (int i = 0; i < chordPaths.Length; i++) {
			bool hasEmptyPoint = false; // flag to check for empty points

			//********* Adjust the fret thru 3 octaves*****************
			int shiftFactor = i / 5; // will be either 0, 1, or 2
			int octaveShift = 12;
			// the shift should be -12, 0, or 12
			int fret = (_rootFret - octaveShift) + (shiftFactor * octaveShift);
			//*********************************************************

			int length = CAGED_shapeInfo [i%5].Length; // %5 to keep in the range 0 to 4, because the shapeInfo array has the same 5 elements, and we loop thru 3x
			Vector2[] chordPath = new Vector2[length];

			for (int j = 0; j < length; j++) {
				// generate the points for each chord
				// first, check that the note will be in existence, not below the 0 fret and not above the highest fret
				if (IsInRange (fret + (int)CAGED_shapeInfo [i % 5] [j].y)) {
					chordPath [j] = GetPoint (fretboard.strings [(int)CAGED_shapeInfo [i % 5] [j].x].GetNote (fret + (int)CAGED_shapeInfo [i % 5] [j].y));
				} else {
					hasEmptyPoint = true;
				}
			}

			//********** Remove null values from path **********
			if (hasEmptyPoint) {
				var temp = new List<Vector2> ();
				foreach (Vector2 pt in chordPath) {
					if ((pt != null && pt != new Vector2 (0, 0))) { 
						
						temp.Add (pt);
					}
				}
				chordPath = temp.ToArray ();
			}
			//**************************************************

			// add chordPath to the array of chordpaths
			chordPaths[i] = chordPath;
		}


		return chordPaths;
	}

	// helper to check whether a note is within the range and therefore exists on the fretboard
	private bool IsInRange(int _fret) {
		return (_fret >= 0 && _fret < fretboard.numFrets);
	}
		

	// helper to get Vector2 from a Note
	private Vector2 GetPoint(Note _note) {
		Vector2 point = new Vector2 (_note.transform.position.x, _note.transform.position.z);
		return point;
	}
}
