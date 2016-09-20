using UnityEngine;
using System.Collections;

public class GuitarString : MonoBehaviour {

	public int numFrets;
	public int openNoteID;
	public int octave; // the octave at the first note (open string)
	public GameObject notePrefab;
	private float spacing; // the width from the nut to the first fret
	private float offset; // the distance to shift the notes left relative to the string, so they are positioned between the frets
	private int[] frets; // not sure if this will be needed
	public Note[] notes;

	// Use this for initialization
	public void Awake () {
	}

	public void Init(int _numFrets, int _openNoteID, int _octave, float _spacing, float _offset) {
		notes = new Note[_numFrets];
		numFrets = _numFrets;
		openNoteID = _openNoteID;
		octave = _octave;
		spacing = _spacing;
		offset = _offset;
		// Add the notes
		for (int i = 0; i < numFrets; i++) {
			Vector3 notePosition = new Vector3 (spacing * i, 0f, transform.position.z);
			GameObject newNote = (GameObject)Instantiate (notePrefab, notePosition, Quaternion.identity);
			newNote.transform.parent = transform;

			// Init() the notes
			notes[i] = newNote.GetComponent<Note>();
			int noteID = (_openNoteID + i) % 12;
			// determine when the string changes octave
			int noteOctave = octave + ((openNoteID + i) / 12); // a truncated int is rounded down towards 0
			notes[i].Init(noteID, noteOctave);
		}
	}

}