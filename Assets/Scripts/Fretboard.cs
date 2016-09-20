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
	public int numStrings;
	public int numFrets;
	public float spacing; // the distance between frets
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

	private GuitarString[] strings;

//	// shouldn't need this -- moved to Scale.cs -- but still in use???
//	public void generateMajorScale(int _rootIndex) {
//		// The pattern of the major scale, shifted to start at the current key
//		bool [] shiftedScale = new bool[12];
//		int j = 0;
//		for (int i = 0; i < 12; i++) {
//			shiftedScale [(_rootIndex + j) % 12] = majorscale [j];
//			j++;
//		}
//
//
//		int k = 0;
//		for (int i=_rootIndex; i<12; i++) {
//			if (shiftedScale[i]) {
//				currentScale[k] = i;
//				k++;
//			}
//		}
//		for (int i=0; i<_rootIndex; i++) {
//			if (shiftedScale[i]) {
//				
//				currentScale[k] = i;
//				k++;
//
//			}
//		}
//	}

	void Awake() {
		numStrings = 6;
		spacing = 3.01f;
		offset = -1.0f;

		strings = new GuitarString[numStrings];
		_scale = GameObject.FindGameObjectWithTag ("Scales").GetComponent<Scale> ();
//		for (int i = 0; i < numStrings; i++) {
//			strings[i] = new GuitarString();
//		
//			switch (i) {
//			case 0: // high E string
//				strings [i].openNoteID = 7;
//				strings [i].octave = 4;
//				break;
//			case 1: // B string
//				strings[i].openNoteID = 2;
//				strings[i].octave = 3;
//				break;
//			case 2: // G string
//
//				break;
//			case 3: // D string
//
//				break;
//			case 4: // A string
//
//				break;
//			case 5: // low E string
//				strings[i].openNoteID = 7;
//				strings[i].octave = 2;
//				break;
//			default: // either E string
//				
//				break;
//			}
//		}
	}

	// Use this for initialization
	void Start () {
		// scales
		majorscale = new bool[] {true, false, true, false, true, true, false, true, false, true, false, true};
		gmajor = new bool[] {true, false, true, true, false, true, false, true, false, true, true, false};
		cmajor = new bool[] {true, false, true, true, false, true, false, true, true, false, true, false};
		scales = new bool[][] { gmajor, cmajor };
		currentScale = new int[7];
		_scale.GenerateMajorScale (10);

		piecePrefabDict = new Dictionary <PieceType, GameObject> ();


		for (int i = 0; i < piecePrefabs.Length; i++) {
			if (!piecePrefabDict.ContainsKey (piecePrefabs [i].type)) {
				piecePrefabDict.Add (piecePrefabs [i].type, piecePrefabs [i].prefab);
			}
		}


		for (int x = 0; x < xDim; x++) {
			for (int y = 0; y < yDim; y++) {
				
				GameObject background = (GameObject)Instantiate (backgroundPrefab, new Vector3 (3.01f * x + 3.0f + 0, 0, -y - 0.8f), Quaternion.identity);
				background.transform.parent = transform;
			}
		}

		notes = new Note[xDim, yDim];
		int octave = 2;

		/************************ Generate the strings **********************/
		int[] openNoteIDs = new int[]{ 7, 2, 10, 5, 0, 7 }; // the ID of the note that each string starts on.
		int[] octaves = new int[]{ 4, 4, 3, 3, 3, 2 }; // the octave that each string starts at. Double check to make sure they're right.
		for (int i = 0; i < numStrings; i++) {
			GameObject newString = (GameObject)Instantiate (stringPrefab, new Vector3 (0f, 0.3f, -1.3f * i), Quaternion.identity);
			newString.transform.parent = transform;
			strings [i] = newString.GetComponent<GuitarString> (); // add the new string to the fretboards array of strings
			strings [i].Init (numFrets, openNoteIDs [i], octaves [i], spacing, offset);


		}
		/********************************************************************/


		//***********deprecated, Init Notes from the Fretboard********************
		/*
		for (int x = 0; x < xDim; x++) {
			for (int y = 0; y < yDim; y++) {
				GameObject newNote = (GameObject)Instantiate (piecePrefabDict [PieceType.NORMAL], new Vector3 (3.01f * x, 0, 1.3f * y), Quaternion.identity);
				newNote.name = "Notes(" + x + "," + y + ")";
				newNote.transform.parent = transform;

				notes[x, y] = newNote.GetComponent<Note>();

				int pitchShift = 0;

				switch (y) {
				case 0: // low E string
					pitchShift = 7;
					if (x > 3) {
						octave = 3;
					} else { octave = 2; }
					break;
				case 1: // A string
					pitchShift = 0;
					octave = 3;
					break;
				case 2: // D string
					pitchShift = 5;
					if (x > 5) {octave = 4;}
					else {octave = 3;}
					break;
				case 3: // G string
					pitchShift = 10;
					if (x == 0) {octave = 3;}
					else {octave = 4;}
					break;
				case 4: // B string
					pitchShift = 2;
					if (x > 8) {octave = 5;}
					else {octave = 4;}
					break;
				case 5: // high E string
					pitchShift = 7;
					if (x > 3) {
						octave = 5;
					} else {
						octave = 4;
					}
					break;
				default: // either E string
					pitchShift = 8;
					break;
				}
				notes[x,y].InitFromFretboard(this, PieceType.NORMAL, pitchShift + x, octave);

			}
		}
		*/
		//********************************************************************/


		SetActiveNotesForScale ();
//		// set up for chord menu
//		List<string> list = new List<string> { "G", "Am", "C", "D" };
//		chordMenu.ClearOptions();
//
//
//		foreach (string option in list)
//		{
//			chordMenu.options.Add(new Dropdown.OptionData(option));
//		}

	}


//	// Old way, from an array of scales
//	public void SetScale(int _scaleID) {
//
//		/******************* Example of foreach to count multi-d array******************/
////		int counter = 0;
////		foreach (Note note in notes) {
////			Debug.Log (note.noteIdentifer + "  *  ");
////			counter++;
////		}
////		Debug.Log ("Counter: " + counter);
//		/*******************************************************************************/
//
//		// TODO:- use a foreach loop, and get the scale from the Scales object****************
//
//		bool[] scale = scales [_scaleID];
//		for (int x = 0; x < xDim; x++) {
//			for (int y = 0; y < yDim; y++) {
//				notes [x, y].gameObject.SetActive (scale[notes [x, y].noteIdentifer]);
//					
//			}
//		}
//	}

	public void SetActiveNotesForScale() {
		//foreach (Note note in notes) { // when using the Notes init'd from Fretboard

		foreach (GuitarString guitarString in strings) {
			foreach (Note note in guitarString.notes) {
				note.gameObject.SetActive (_scale.scalePattern[note.noteIdentifer]);
			}
		}
	}

	public void SetNoteColorsByChord(int _chordID) {

		//foreach (Note note in notes) {
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

//	void ResetNoteColors() {
//		for (int x = 0; x < xDim; x++) {
//			for (int y = 0; y < yDim; y++) {
//				notes [x, y].noteText.color = Color.HSVToRGB (notes[x, y].noteColor, 1.0f, 1.0f);
//			}
//		}
//	}

//	Vector2 GetWorldPosition(int x, int y) {
//		return new Vector2 (transform.position.x - xDim / 2.0f + x, transform.position.y + yDim / 2.0f - y);
//
//	}
	Vector3 GetWorldPosition(int x, int y) {
		return new Vector3 (transform.position.x - xDim / 2.0f + (3.01f * x), 0.0f, transform.position.y + yDim / 2.0f - y);

	}


	

}
 