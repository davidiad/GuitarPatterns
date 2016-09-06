using UnityEngine;
using System.Collections;

public class Scale : MonoBehaviour {

	public int rootIndex;
	public int[] scale;
	public Chord[] chords;
	public string[] chordNames; // chordNames duplicates chord.name, but allows viewing in Inspector

	private bool[] majorScalePattern;

//	private string[] noteNames; // replace this with something linked to Note object ?

	private NoteInfo noteInfo; // to retrieve basic info like the string associated with each note index

	// Use this for initialization
	void Awake () {
		majorScalePattern = new bool[] {true, false, true, false, true, true, false, true, false, true, false, true};
		scale = new int[7];
		chords = new Chord[7];
		chordNames = new string[7];
		for (int i = 0; i < 7; i++) {
			chords [i] = new Chord ();
		}

//		noteNames = new string[12];
		noteInfo = GameObject.FindGameObjectWithTag ("NoteInfo").GetComponent<NoteInfo> ();
	}
	

	void Start () {
		// The pattern for the scale in order by the index of each note
		// For instance, G Major contains  the 7 notes (G, A, B, C, D, E, F#) so
		// the pattern by index is (10, 0, 2, 3, 5, 7, 9)

		/**********************
		Next, need to get the letter name of the chord from the index number, and use it to build the chord name
		// and then, make it so that the scale can be updated in GenerateMajorScale(), so just one Scale object can be used in game 
		***********************/

		GenerateMajorScale (rootIndex); 

		// either need to create the notes to reference, or use existing notes, or else generate a new note here
		// but would not be good to generate a new set of notes each time a chord is referenced!

		// setting the major chord
		//chords[0] = new Chord();
		chords [0].Init (scale[0], scale[2], scale[4]);
		chords [1].Init (scale[6], scale[2], scale[0]);
		chords [2].Init (scale[3], scale[5], scale[0]);
		chords [3].Init (scale[4], scale[6], scale[1]);

		chords [1].name = noteInfo.PitchNames [scale [5]] + "m";
		chordNames [1] = chords [1].name;
//		for (int i = 0; i < 7; i++) {
//			chords [i].name = "G-chord " + i;
//			chordNames [i] = chords [i].name;
//		}
			


	}

	private void GenerateMajorScale(int _rootIndex) {
		// The pattern of the major scale, shifted to start at the current key
		bool [] shiftedScalePattern = new bool[12];
		int j = 0;
		for (int i = 0; i < 12; i++) {
			shiftedScalePattern [(_rootIndex + j) % 12] = majorScalePattern [j];
			j++;
		}


		int k = 0;
		for (int i=_rootIndex; i<12; i++) {
			if (shiftedScalePattern[i]) {
				scale[k] = i;
				k++;
			}
		}
		for (int i=0; i<_rootIndex; i++) {
			if (shiftedScalePattern[i]) {

				scale[k] = i;
				k++;

			}
		}
		Debug.Log("The Scale:   ");
		for (int i=0; i<scale.Length; i++) {
			Debug.Log(" " + scale[i] + " ");
		}

	}

	private void GenerateChords() {
		//chords [0].notes [0] = noteNames [scale [0]];

	}
}
