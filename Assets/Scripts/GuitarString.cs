using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GuitarString : MonoBehaviour {

	public int numFrets;
	public int openNoteID;
	public int octave; // the octave at the first note (open string)
	public GameObject notePrefab;
	private float spacing; // the width from the nut to the first fret
	private float offset; // the distance to shift the notes left relative to the string, so they are positioned between the frets
	private int[] frets; // not sure if this will be needed
	public Note[] notes;
	private float[] _fretPositions;

	public void Init(int _numFrets, int _openNoteID, int _octave, float _spacing, float _offset) {
		_fretPositions = GameObject.FindGameObjectWithTag ("Fretboard").GetComponent<Fretboard> ().fretPositions;
		notes = new Note[_numFrets + 1];
		numFrets = _numFrets;
		openNoteID = _openNoteID;
		octave = _octave;
		spacing = _spacing;
		offset = _offset;
		// Add the notes
		for (int i = 0; i <= numFrets; i++) {
			float noteXPos;
			//Vector3 notePosition = new Vector3 (spacing * i, 0f, transform.position.z);
//			GameObject newNote = (GameObject)Instantiate (notePrefab, notePosition, Quaternion.identity);
			GameObject newNote = (GameObject)Instantiate (notePrefab, transform);
			//newNote.transform.parent = transform;
			if (i > 0) {
				noteXPos = (100.0f *  (_fretPositions [i] - ((_fretPositions [i] - _fretPositions [i - 1]) * 0.5f))) - _offset;
			} else {
				noteXPos = 0;
			}
			newNote.transform.localPosition = new Vector3(noteXPos, 0f, 0f);

			// Init() the notes
			notes[i] = newNote.GetComponent<Note>();
			int noteID = (_openNoteID + i) % 12;
			// determine when the string changes octave
			int noteOctave = octave + ((openNoteID + i) / 12); // a truncated int is rounded down towards 0
			notes[i].Init(noteID, noteOctave, i); // i is the number of the fret the note is on
		}
	}

	// Access the note on a string to get its transform, used to build chord shapes
	// Get the Note(s) and its fret that's on the root note on the 1st String
	// Put in the root note ID
	// Get out the fret(s) it is on
	// Get the transform.position of that Note(s)

	// returns the frets where the rootNote reside on the 1st string
	public List <int> GetFrets(int _rootNote) {
		List <int> rootFrets = new List<int>();
		for (int i=0; i<notes.Length; i++) {
			if (notes [i].noteIdentifer == _rootNote) {
				rootFrets.Add(notes[i].fret);
			}
		}
		return rootFrets;
	}

	public Note GetNote(int _fret) {
		return notes [_fret];
	}

}