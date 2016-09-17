using UnityEngine;
using System.Collections;

public class GuitarString : MonoBehaviour {

	public int numFrets;
	public int openNoteID;
	public int octave;
	private float spacing; // the width from the nut to the first fret
	private float offset; // the distance to shift the notes left relative to the string, so they are positioned between the frets
	private int[] frets; // not sure if this will be needed
	private Note[] notes;

	// Use this for initialization
	public void Awake () {

	}

	public void Init(int _numFrets, int _openNoteID, int _octave, float _spacing, float _offset) {
		numFrets = _numFrets;
		openNoteID = _openNoteID;
		octave = _octave;
		spacing = _spacing;
		offset = _offset;
		// Add the notes

	}

}