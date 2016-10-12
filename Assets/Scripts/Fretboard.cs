using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using UnityEngine.UI;

public class Fretboard : MonoBehaviour {
	


	public enum PieceType 
	{
		NORMAL,
		COUNT,
	};

	[System.Serializable]

	public struct PiecePrefab 
	{
		public PieceType type;
		public GameObject prefab;
	};


	public GameObject stringPrefab;
	public GameObject neckPrefab;
	public GameObject fretPrefab;
	private ChordShapes chordShapes;
	public int numStrings;
	public int numFrets;
	public float scaleLength; // twice the distance from nut to 12th fret, used to calculate fret spacing 
	// for Yamaha APX 3/4 size electric acoustic guitar
	// 0.90656, which is 2 * 11-7/16" * 3.9631 (conversion from actual guitar to 3D model) * 0.01 (scaling from Blender to Unity)
	public float fretSpacing; // the distance bet nut and first fret (may not need this if computing from scaleLength)
	public Vector2 fretScaling; // x scales the x position; y scale the z scale
	public float spacing; // the distance between frets, deprecated


	public float offset; // the shift of note positions left, so they are positioned in between frets
	public int xDim;
	public int yDim;

	public PiecePrefab[] piecePrefabs;
	public GameObject backgroundPrefab;

	private Dictionary<PieceType, GameObject> piecePrefabDict;

	public Note[,] notes;
	public string[] noteArray;

	public bool[] gmajor;
	public bool[] cmajor;
	public bool[][] scales;

	public bool[] majorscale;
	public int[] currentScale;

	private Scale _scale;

	public GuitarString[] strings;
	public float[] fretPositions; // the x position of each fret

	void Awake() {
		
		fretPositions = new float[numFrets + 1]; // the number of frets plus 1 for the nut at position 0
		//************* Calculate fret positions ****************************************
		fretPositions[0] = 0; // the position of the nut, open strings
		for (int i = 1; i <= numFrets; i++) {
			float bridgeToPreviousFret = scaleLength - fretPositions [i - 1];
			fretPositions [i] = (bridgeToPreviousFret / 18.3f) + fretPositions [i - 1];
		}
		//*******************************************************************************


		numStrings = 6;
		spacing = 3.01f;
		offset = -1.0f;

		strings = new GuitarString[numStrings];
		_scale = GameObject.FindGameObjectWithTag ("Scales").GetComponent<Scale> ();

	}

	// Use this for initialization
	void Start () {
		// scales
		majorscale = new bool[] { true, false, true, false, true, true, false, true, false, true, false, true };
		gmajor = new bool[] { true, false, true, true, false, true, false, true, false, true, true, false };
		cmajor = new bool[] { true, false, true, true, false, true, false, true, true, false, true, false };
		scales = new bool[][] { gmajor, cmajor };
		currentScale = new int[7];
		_scale.GenerateMajorScale (10);

//		piecePrefabDict = new Dictionary <PieceType, GameObject> ();
//
//
//
//		for (int i = 0; i < piecePrefabs.Length; i++) {
//			if (!piecePrefabDict.ContainsKey (piecePrefabs [i].type)) {
//				piecePrefabDict.Add (piecePrefabs [i].type, piecePrefabs [i].prefab);
//			}
//		}
//
//
//		for (int x = 0; x < xDim; x++) {
//			for (int y = 0; y < yDim; y++) {
//				
//				GameObject background = (GameObject)Instantiate (backgroundPrefab, new Vector3 (3.01f * x + 3.0f + 0, 0, -y - 0.8f), Quaternion.identity);
//				background.transform.parent = transform;
//			}
//		}

		notes = new Note[xDim, yDim];
		int octave = 2;

		/************************ Generate the frets **********************/
		for (int i=1; i <= numFrets; i++) {
			GameObject fret = (GameObject)Instantiate (fretPrefab, neckPrefab.transform);
			fret.transform.rotation = Quaternion.identity; 
			fret.transform.localPosition = new Vector3 (fretPositions[i], 0f, 0f);
			fret.transform.localScale = new Vector3 ( 1f, 1f, Mathf.Pow(fretScaling.y, i-1) );
		}
		/********************************************************************/

		/************************ Generate the strings **********************/
		int[] openNoteIDs = new int[]{ 7, 2, 10, 5, 0, 7 }; // the ID of the note that each string starts on.
		int[] octaves = new int[]{ 4, 4, 3, 3, 3, 2 }; // the octave that each string starts at. Double check to make sure they're right.
		for (int i = 0; i < numStrings; i++) {
			//GameObject newString = (GameObject)Instantiate (stringPrefab, new Vector3 (0f, 0.3f, -1.3f * i), Quaternion.identity);
			GameObject newString = (GameObject)Instantiate (stringPrefab, neckPrefab.transform);
			//newString.transform.parent = neckPrefab.transform;
			newString.transform.localPosition = new Vector3(offset * 0.01f, .005f, -0.012f * i + .03f);
			strings [i] = newString.GetComponent<GuitarString> (); // add the new string to the fretboards array of strings
			strings [i].Init (numFrets, openNoteIDs [i], octaves [i], spacing, offset);


		}
		/********************************************************************/
		chordShapes = GameObject.FindGameObjectWithTag ("ChordShapes").GetComponent<ChordShapes> ();
	}

	public void SetActiveNotesForScale() {
		//foreach (Note note in notes) { // when using the Notes init'd from Fretboard

		foreach (GuitarString guitarString in strings) {
			foreach (Note note in guitarString.notes) {
				//note.gameObject.SetActive (_scale.scalePattern[note.noteIdentifer]);

				bool visibility = _scale.scalePattern [note.noteIdentifer];
				// Turn off the visibility of the notes not in the scale, but leave them playable
				Renderer rend = note.gameObject.GetComponent<Renderer>();
				rend.enabled = visibility;
				// get the mesh renderer of the note text mesh, and turn that on/off as well
				Renderer text_rend = note.noteText.GetComponent<Renderer>();
				text_rend.enabled = visibility;
			}
		}
	}

	public void DisplayChords(int _chordRootID) {
		SetNoteColorsByChord (_chordRootID);
		MakeChordShapes (_chordRootID);
	}

	public void SetNoteColorsByChord(int _chordID) {
		foreach (GuitarString guitarString in strings) {
			foreach (Note note in guitarString.notes) {
				if (isNoteInChord (_scale.chords [_chordID], note) == true) {
					note.colorOn (true);
				} else {
					note.colorOn (false);
				}
			}
		}
	}

	private void MakeChordShapes(int _chordRootID) {
		

		// getting the root note on the 2nd string
		List <int> currentRootFrets = strings [2].GetFrets (_scale.chords [_chordRootID].noteIDs[0]);

		// Get all of the chordPaths
		Vector2[][] chordPaths = chordShapes.GetChordShapes (currentRootFrets[0]);

		for (int i = 0; i < chordPaths.Length; i++) {
			ChordShape chordShape = new ChordShape();
			chordShape.SetPoints (chordPaths[i]);
			GetComponent<VectorChord> ().DrawChord (chordShape, i, _scale.chords [_chordRootID].noteIDs[0]);
		}
			
	}

	// helper function to check whether a note is in the currently active chord
	// ? should this function be moved to Chord object? or to Note object?
	public bool isNoteInChord(Chord _chord, Note _note) {
		for (int i = 0; i < _chord.noteIDs.Length; i++) {
			if (_note.noteIdentifer == _chord.noteIDs [i]) {
				return true;
			}
		}
		return false;
	}
			
	Vector3 GetWorldPosition(int x, int y) {
		return new Vector3 (transform.position.x - xDim / 2.0f + (3.01f * x), 0.0f, transform.position.y + yDim / 2.0f - y);

	}
			

}
 