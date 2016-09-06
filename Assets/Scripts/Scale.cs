using UnityEngine;
using System.Collections;

public class Scale : MonoBehaviour {

	public int[] scale;
	public Chord[] chords;
	public int rootIndex;
	private bool[] majorScalePattern;

	private string[] noteNames; // replace this with something linked to Note object


	// Use this for initialization
	void Awake () {
		majorScalePattern = new bool[] {true, false, true, false, true, true, false, true, false, true, false, true};
		scale = new int[7];
		chords = new Chord[7];
		noteNames = new string[12];
	}
	

	void Start () {
		// The pattern for the scale in order by the index of each note
		// For instance, G Major contains  the 7 notes (G, A, B, C, D, E, F#) so
		// the pattern by index is (10, 0, 2, 3, 5, 7, 9)
		GenerateMajorScale (rootIndex); 
		chords [0] = new Chord ();
		// either need to create the notes to reference, or use existing notes, or else generate a new note here
		// but would not be good to generate a new set of notes each time a chord is referenced!

		// setting the major chord
		chords [0].noteIDs[0] = scale[0];
		chords [0].noteIDs [1] = scale [2];
		chords [0].noteIDs [2] = scale [4];

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
