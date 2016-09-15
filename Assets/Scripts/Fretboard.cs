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

	// shouldn't need this -- moved to Scale.cs -- but still in use???
	public void generateMajorScale(int _rootIndex) {
		// The pattern of the major scale, shifted to start at the current key
		bool [] shiftedScale = new bool[12];
		int j = 0;
		for (int i = 0; i < 12; i++) {
			shiftedScale [(_rootIndex + j) % 12] = majorscale [j];
			j++;
		}


		int k = 0;
		for (int i=_rootIndex; i<12; i++) {
			if (shiftedScale[i]) {
				currentScale[k] = i;
				k++;
			}
		}
		for (int i=0; i<_rootIndex; i++) {
			if (shiftedScale[i]) {
				
				currentScale[k] = i;
				k++;

			}
		}
	}

	void Awake() {
		_scale = GameObject.FindGameObjectWithTag ("Scales").GetComponent<Scale> ();
	}

	// Use this for initialization
	void Start () {
		// scales
		majorscale = new bool[] {true, false, true, false, true, true, false, true, false, true, false, true};
		gmajor = new bool[] {true, false, true, true, false, true, false, true, false, true, true, false};
		cmajor = new bool[] {true, false, true, true, false, true, false, true, true, false, true, false};
		scales = new bool[][] { gmajor, cmajor };
		currentScale = new int[7];
		generateMajorScale (10);
		// start from the root eg G = 10
//		/g_major = new int [7];
//		for 10 to end
//			if true, add ThreadSafeAttribute index Touch gmaj
//				again, from 0 til 10

		//noteArray = ["A", "A#", "B", "C", "C#", 
		piecePrefabDict = new Dictionary <PieceType, GameObject> ();

		for (int i = 0; i < piecePrefabs.Length; i++) {
			if (!piecePrefabDict.ContainsKey (piecePrefabs [i].type)) {
				piecePrefabDict.Add (piecePrefabs [i].type, piecePrefabs [i].prefab);
			}
		}

		for (int x = 0; x < xDim; x++) {
			for (int y = 0; y < yDim; y++) {
				
				GameObject background = (GameObject)Instantiate (backgroundPrefab, new Vector3 (3.01f * x + 3.0f + 0, 0, y + 0.8f), Quaternion.identity);
				background.transform.parent = transform;
			}
		}

		notes = new Note[xDim, yDim];
		int octave = 2;

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
				notes[x,y].Init(this, PieceType.NORMAL, pitchShift + x, octave);

				//notes [x, y].NoteComponent.SetPitch ((Note.PitchType)Random.Range (0, notes [x, y].NoteComponent.NumPitches));
			}
		}
		//SetScale (10);
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
		foreach (Note note in notes) {

			//Debug.Log("Is it true? " + _scale.scalePattern[0]);
			note.gameObject.SetActive (_scale.scalePattern[note.noteIdentifer]);
		}
	}

	public void SetNoteColorsByChord(int _chordID) {
		//Debug.Log ("CHORD: " + _scale.chords [_chordID].name);
		//need to pass in scale.chords[0] (for now)
		// we are getting 0, 1, or 2 from the dropdownmenu
		// ?Start with G major scale already instantiated? Including its chords? 
		// Should scales be instantiated and saved as they are needed?
		// Woulnd't want to have to recreate a scale each time it is switched to. or chords.
//		switch (_chordID) {
//		case 0: // G chord
//			_chordID = 10;
//			break;
//		case 1: // C chord
//			_chordID = 3;
//			break;
//		case 2: // D chord
//			_chordID = 5;
//			break;
//		}


		// The question: Given the notes in a chord, how to find all the notes of a chord, and change their colors??
		// Add a bool property to Note that turns the color on or off? Better than recalculating the color each time.
		// How to check whether a note is in the current chord. If this was Swift, would probably use a Set to check inclusion.
		// But only checking 3 or so values, so maybe a loop is ok
		// Maybe a helper function that checks the noteID against all 3+ notes in the chord? A simple switch: case, or a simple loop
		// What's the best way to iterate thru all the notes on the fretboard? foreach

//		for (int x = 0; x < xDim; x++) {
//			for (int y = 0; y < yDim; y++) {
//				if ( notes [x, y].noteIdentifer != _chordID && notes [x, y].noteIdentifer != 2 && notes [x, y].noteIdentifer != 5  )
//				{
//					notes [x, y].noteText.color = Color.gray;
//				}
//
//				if (notes [x, y].noteIdentifer == _chordID) {
//					notes [x, y].noteText.color = Color.HSVToRGB (notes [x, y].noteColor, 1.0f, 1.0f);
//				} else if (notes [x, y].noteIdentifer == ((_chordID + 4) % 12)) {
//					notes [x, y].noteText.color = Color.HSVToRGB (notes [x, y].noteColor, 1.0f, 1.0f);
//				} else if (notes [x, y].noteIdentifer == ((_chordID + 7) % 12)) {
//					notes [x, y].noteText.color = Color.HSVToRGB (notes [x, y].noteColor, 1.0f, 1.0f);
//				} else {
//					notes [x, y].noteText.color = Color.gray;
//				}
//			}
//		}


		foreach (Note note in notes) {
			if (isNoteInChord(_scale.chords[_chordID], note) == true) {
				note.colorOn (true);
			} else {
				note.colorOn (false);
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
 