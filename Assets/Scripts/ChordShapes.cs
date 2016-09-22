using UnityEngine;
using System.Collections;

public class ChordShapes : MonoBehaviour {

	public ChordShape[] chordShapes;
	public int rootNote;
	public GameObject fretboardObject; // need the fretboard to access the strings which hold the notes
	private Fretboard fretboard;

	void Awake () {
		chordShapes = new ChordShape[5];
		fretboard = fretboardObject.GetComponent<Fretboard> ();
	}

	void Start () {
		for (int i = 0; i < chordShapes.Length; i++) {
			chordShapes [i] = new ChordShape ();
		}
		//UpdateChordShapes (10);
	}

//	public void UpdateChordShapes(int _rootNote) {
//		// Fretboard>strings[0]> GetFrets() to return a list of the root fret
//		Debug.Log("strings: " + fretboard.strings);
//		Debug.Log("strings[0]: " + fretboard.strings[0]);
//		int rootFret = fretboard.strings[0].GetFrets(_rootNote)[0];
//
//		Debug.Log ("rootFret: " + rootFret);
//		Debug.Log (fretboard);
//
//		Cshape (rootFret);
//		Ashape (rootFret);
//		Gshape (rootFret);
//		Debug.Log (chordShapes [0]);
//		GetComponent<VectorChord> ().DrawChord (chordShapes[0]);
//		GetComponent<VectorChord> ().DrawChord (chordShapes[1]);
//		GetComponent<VectorChord> ().DrawChord (chordShapes[2]);
//	}

	public Vector2[] Cshape(int _rootFret) {
		Vector2 pt0 = GetPoint(fretboard.strings[1].GetNote(_rootFret + 5));
		Vector2 pt1 = GetPoint(fretboard.strings[3].GetNote(_rootFret + 6));
		Vector2 pt2 = GetPoint(fretboard.strings[4].GetNote(_rootFret + 7));
		Vector2[] chordPoints = new Vector2[] {pt0, pt1, pt2};
		//chordShapes[0].SetPoints (chordPoints);
		return chordPoints;
	}

	public Vector2[] Ashape(int _rootFret) {
		Vector2 pt0 = GetPoint(fretboard.strings[1].GetNote(_rootFret - 3));
		Vector2 pt1 = GetPoint(fretboard.strings[2].GetNote(_rootFret - 3));
		Vector2 pt2 = GetPoint(fretboard.strings[3].GetNote(_rootFret - 3));
		Vector2[] chordPoints = new Vector2[] {pt0, pt1, pt2};
		//chordShapes[1].SetPoints (chordPoints);
		return chordPoints;

	}

	// Define the G shape chord
	private void Gshape(int _rootFret) {
		// Given the root fret, the first note is the 1st string, root fret
		// Fretboard>strings[0]>GetNote(_rootFret) -> returns the note, and get the transform from that note
		// chordShapes[0].chordPoints[0] = GetPoint(the Note) // may need to change chordPoints to a List, because the length will vary
		// 2nd note is 6th string, root fret
		// 3rd note is 5th string, root fret - 1
		Vector2 pt0 = GetPoint(fretboard.strings[0].GetNote(_rootFret));
		Vector2 pt1 = GetPoint(fretboard.strings[5].GetNote(_rootFret));
		Vector2 pt2 = GetPoint(fretboard.strings[4].GetNote(_rootFret - 1));
		Vector2[] chordPoints = new Vector2[] {pt0, pt1, pt2};
		chordShapes[1].SetPoints (chordPoints);
	}

	// Define the D shape chord
	private void Dshape(int _rootFret) {
		// the first note is the 1st string, root fret -1
		// 2nd note is 2nd string, root fret
		// 3rd note is 3rd string, root fret - 1
	}

	// helper to get Vector2 from a Note
	private Vector2 GetPoint(Note _note) {
		Vector2 point = new Vector2 (_note.transform.position.x, _note.transform.position.z);
		return point;
	}
}
