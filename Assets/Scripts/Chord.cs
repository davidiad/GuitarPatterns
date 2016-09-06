using UnityEngine;
using System.Collections;

public class Chord {

	public string name;
	//public Note[] notes;
	public int[] noteIDs;

	 public void Init(int _rootNoteIndex, int _note2, int _note3) {
		noteIDs = new int[3];
		noteIDs [0] = _rootNoteIndex;
		noteIDs [1] = _note2;
		noteIDs [2] = _note3;

	}

}
