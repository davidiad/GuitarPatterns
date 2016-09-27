using UnityEngine;
using System.Collections;

public class ChordShapes : MonoBehaviour {

	public ChordShape[] chordShapes;
	public int rootNote;
	public GameObject fretboardObject; // need the fretboard to access the strings which hold the notes
	private Fretboard fretboard;

	private Vector2[][] CAGED_shapeInfo;

	void Awake () {
		chordShapes = new ChordShape[5];
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
		Vector2[] D_shapeInfo = new Vector2[3] { new Vector2(0,7), new Vector2(1,8), new Vector2 (2, 7) };

		CAGED_shapeInfo = new Vector2[5][] { C_shapeInfo, A_shapeInfo, G_shapeInfo, E_shapeInfo, D_shapeInfo };
	}

	public Vector2[][] GetChordShapes(int _rootFret) {
		// Start with A shape for G chord. _rootFret = 0 (on the 3rd string)
		Vector2[][] chordPaths = new Vector2[5][];

//		int[][] chordRelationships = new int[5][];
//		int[] chordStringsA = new int[] { 1, 2, 3 };
//		int[] chordFretsA = new int[] { 0, 0, 0 }; // the root fret passed in needs to be for the open strings
//
//		int[][] C_relations = new int[][] { new int[]{1,8}, new int[]{3,9}, new int[]{4,10}, new int[]{5,10} };
//		int[][] A_relations = new int[][] { new int[]{1,0}, new int[]{2,0}, new int[]{3,0} };
//		int[][] G_relations = new int[][] { new int[]{0,3}, new int[]{1,3}, new int[]{5,3}, new int[]{4,2} };
//		int[][] E_relations = new int[][] { new int[]{0,3}, new int[]{1,3}, new int[]{2,4}, new int[]{3,5}, new int[]{4,5} };
//		int[][] D_relations = new int[][] { new int[]{0,7}, new int[]{1,8}, new int[]{2,7} };

//		Vector2[] C_shapeInfo = new Vector2[4] { new Vector2(1,8), new Vector2(3,9), new Vector2(4,10), new Vector2(5,10) };
//		Vector2[] A_shapeInfo = new Vector2[3] { new Vector2(1,0), new Vector2(2,0), new Vector2(3,0) };
//		Vector2[] G_shapeInfo = new Vector2[4] { new Vector2(0,3), new Vector2(1,3), new Vector2(5,3), new Vector2(4,2) };
//		Vector2[] E_shapeInfo = new Vector2[5] { new Vector2(0,3), new Vector2(1,3), new Vector2(2,4), new Vector2(3,5), new Vector2(4,5) };
//		Vector2[] D_shapeInfo = new Vector2[3] { new Vector2(0,7), new Vector2(1,8), new Vector2 (2, 7) };
//
//		CAGED_shapeInfo = new Vector2[5][] { C_shapeInfo, A_shapeInfo, G_shapeInfo, E_shapeInfo, D_shapeInfo };

		for (int i = 0; i < 5; i++) {
			int length = CAGED_shapeInfo [i].Length;
			Vector2[] chordPath = new Vector2[length];
			//Vector2[][] chord_shapeInfo = new Vector2[][] {CAGED_shapeInfo[i] };

			for (int j = 0; j < length; j++) {
				// generate the points for each chord
				// first, check that the note will be in existance, not below the 0 fret and not above the highest fret
				// check for being in range: _rootFret + (int)CAGED_shapeInfo[i][j].y)
				if (IsInRange (_rootFret + (int)CAGED_shapeInfo [i] [j].y)) {
					chordPath [j] = GetPoint (fretboard.strings [(int)CAGED_shapeInfo [i] [j].x].GetNote (_rootFret + (int)CAGED_shapeInfo [i] [j].y));
				}
			}
			// add chordPath to the array of chordpaths
			chordPaths[i] = chordPath;
		}
//		//********* Log info*********
//		foreach(Vector2[] cp in chordPaths) {
//			foreach (Vector2 pts in cp) {
//				Debug.Log (pts.ToString ());
//			}
//		}
//		// **************************


		return chordPaths;
	}

	// helper to check whether a note is within the range and therefore exists on the fretboard
	private bool IsInRange(int _fret) {
		return (_fret >= 0 && _fret < fretboard.numFrets);
	}

//	public Vector2[] Cshape(int _rootFret) {
//		Vector2 pt0 = GetPoint(fretboard.strings[1].GetNote(_rootFret + 5));
//		Vector2 pt1 = GetPoint(fretboard.strings[3].GetNote(_rootFret + 6));
//		Vector2 pt2 = GetPoint(fretboard.strings[4].GetNote(_rootFret + 7));
//		Vector2 pt3 = GetPoint(fretboard.strings[5].GetNote(_rootFret + 7));
//		Vector2[] chordPoints = new Vector2[] {pt0, pt1, pt2, pt3};
//		//chordShapes[0].SetPoints (chordPoints);
//		return chordPoints;
//	}
//
//	public Vector2[] Ashape(int _rootFret) {
//		Vector2 pt0 = GetPoint(fretboard.strings[1].GetNote(_rootFret - 3));
//		Vector2 pt1 = GetPoint(fretboard.strings[2].GetNote(_rootFret - 3));
//		Vector2 pt2 = GetPoint(fretboard.strings[3].GetNote(_rootFret - 3));
//		Vector2[] chordPoints = new Vector2[] {pt0, pt1, pt2};
//		//chordShapes[1].SetPoints (chordPoints);
//		return chordPoints;
//	}
//
//	public Vector2[] Eshape(int _rootFret) {
//		Vector2 pt0 = GetPoint(fretboard.strings[0].GetNote(_rootFret));
//		Vector2 pt1 = GetPoint(fretboard.strings[1].GetNote(_rootFret));
//		Vector2 pt2 = GetPoint(fretboard.strings[2].GetNote(_rootFret + 1));
//		Vector2 pt3 = GetPoint(fretboard.strings[3].GetNote(_rootFret + 2));
//		Vector2 pt4 = GetPoint(fretboard.strings[4].GetNote(_rootFret + 2));
//		Vector2[] chordPoints = new Vector2[] {pt0, pt1, pt2, pt3, pt4};
//		return chordPoints;
//	}
//		
//
//	// Define the G shape chord
//	private void Gshape(int _rootFret) {
//		// Given the root fret, the first note is the 1st string, root fret
//		// Fretboard>strings[0]>GetNote(_rootFret) -> returns the note, and get the transform from that note
//		// chordShapes[0].chordPoints[0] = GetPoint(the Note) // may need to change chordPoints to a List, because the length will vary
//		// 2nd note is 6th string, root fret
//		// 3rd note is 5th string, root fret - 1
//		Vector2 pt0 = GetPoint(fretboard.strings[0].GetNote(_rootFret));
//		Vector2 pt1 = GetPoint(fretboard.strings[5].GetNote(_rootFret));
//		Vector2 pt2 = GetPoint(fretboard.strings[4].GetNote(_rootFret - 1));
//		Vector2[] chordPoints = new Vector2[] {pt0, pt1, pt2};
//		chordShapes[1].SetPoints (chordPoints);
//	}
//
//	// Define the D shape chord
//	public Vector2[] Dshape(int _rootFret) {
//		// the first note is the 1st string, root fret -1
//		// 2nd note is 2nd string, root fret
//		// 3rd note is 3rd string, root fret - 1
//		Vector2 pt0 = GetPoint(fretboard.strings[0].GetNote(_rootFret + 4));
//		Vector2 pt1 = GetPoint(fretboard.strings[1].GetNote(_rootFret + 5));
//		Vector2 pt2 = GetPoint(fretboard.strings[2].GetNote(_rootFret + 4));
//		Vector2 pt3 = GetPoint(fretboard.strings[5].GetNote(_rootFret + 4));
//		Vector2[] chordPoints = new Vector2[] {pt0, pt1, pt2, pt3};
//		return chordPoints;
//	}

	// helper to get Vector2 from a Note
	private Vector2 GetPoint(Note _note) {
		Vector2 point = new Vector2 (_note.transform.position.x, _note.transform.position.z);
		return point;
	}
}
