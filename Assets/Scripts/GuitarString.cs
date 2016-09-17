using UnityEngine;
using System.Collections;

public class GuitarString : MonoBehaviour {

	public int numFrets;
	public int openNoteID;
	public int octave;
	private int[] frets;
	private Note[] notes;
	//public GuitarString stringComponent;

	// Use this for initialization
	public void Awake () {
		//stringComponent = GetComponent<GuitarString> ();
	}

	public void Init(int _numFrets, int _openNoteID, int _octave) {
		numFrets = _numFrets;
		openNoteID = _openNoteID;
		octave = _octave;

		// Add the notes
		// but need the spacing
	}

}