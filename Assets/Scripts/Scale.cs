﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Scale : MonoBehaviour {

	public int rootIndex;
	public Dropdown chordMenu;
	public Dropdown scaleMenu;
	public int[] scale;
	public Chord[] chords;
	public string[] chordNames; // chordNames duplicates chord.name, but allows viewing in Inspector

	private bool[] majorScalePattern;

//	private string[] noteNames; // replace this with something linked to Note object ?

	private NoteInfo noteInfo; // to retrieve basic info like the string associated with each note index


	private string[] chordPrefix;
	private string[] sharps;
	private string[] chordPostfix;

	// Use this for initialization
	void Awake () {
		majorScalePattern = new bool[] {true, false, true, false, true, true, false, true, false, true, false, true};
		chordPrefix = new string[] {"I: ", "ii: ", "iii: ", "IV: ", "V: ", "vi: ", "vii: "};
//		sharps = new string[] {"", "", "", "", "", "", ""}; // will be blank string unless the note is sharped
		chordPostfix = new string[] {"", "m", "m", "", "", "m", " dim"};

		scale = new int[7];
		chords = new Chord[7];
		chordNames = new string[7];
		for (int i = 0; i < 7; i++) {
			chords [i] = new Chord ();
		}


		noteInfo = GameObject.FindGameObjectWithTag ("NoteInfo").GetComponent<NoteInfo> ();
	}
	

	void Start () {


		ScaleMenuSetup ();

		// The pattern for the scale in order by the index of each note
		// For instance, G Major contains  the 7 notes (G, A, B, C, D, E, F#) so
		// the pattern by index is (10, 0, 2, 3, 5, 7, 9)

		/**********************
		Next, need to get the letter name of the chord from the index number, and use it to build the chord name
		// and then, make it so that the scale can be updated in GenerateMajorScale(), so just one Scale object can be used in game 
		***********************/


		//TODO: - set up the scale menu here (keep in Start) //		ScaleMenuSetup ();
		// then. put all these into a separate func: SetScale() ? ChangeScale() ? SetupScale() ? ScaleSetUp() ?
		// except scale munu setup should probably not be inside set scale

//		GenerateMajorScale (rootIndex);
//		GenerateChords ();
//		ChordMenuSetup ();

		ChangeScale (rootIndex);
//		// Generate the Chords for the Scale
//		for (int i = 0; i < 7; i++) {
//			// each chord is made up of the 1st root note, followed by one 2 notes above in the scale, followed by 2 notes above that
//			// circling back to the first one after the 7th, hence the modulus operation
//			int j = (i + 2) % 7;
//			int k = (i + 4) % 7;
//			chords [i].Init (scale [i], scale [j], scale [k]);
//
//			if (noteInfo.Sharps[scale[i]]) {
//				sharps [i] += "#";
//			}
//
//			chords[i].name = chordPrefix[i] + noteInfo.PitchNames [scale [i]] + sharps[i] + chordPostfix[i];
//			chordNames [i] = chords [i].name;
//		}

//		ChordMenuSetup ();
	}

	public void ChangeScale(int _rootIndex) {
		GenerateMajorScale (_rootIndex);
		GenerateChords ();
		ChordMenuSetup ();
	}

	private void ScaleMenuSetup() {
		scaleMenu.ClearOptions ();
		for (int i = 0; i < 12; i++) {
			string option = noteInfo.NoteRichTexts [i];
			if (noteInfo.Sharps [i]) {
				option += "#";
			}
			scaleMenu.options.Add (new Dropdown.OptionData (option));
		}
	}

	private void ChordMenuSetup() {
		chordMenu.ClearOptions();

		foreach (string option in chordNames) {
			chordMenu.options.Add(new Dropdown.OptionData(option));
		}
	}

	private void GenerateChords() {
		// Generate the Chords for the Scale

		// reset the sharp string each time, so we get only 1 # symbol per note
		sharps = new string[] {"", "", "", "", "", "", ""}; // will be blank string unless the note is sharped

		for (int i = 0; i < 7; i++) {
			// each chord is made up of the 1st root note, followed by one 2 notes above in the scale, followed by 2 notes above that
			// circling back to the first one after the 7th, hence the modulus operation
			int j = (i + 2) % 7;
			int k = (i + 4) % 7;
			chords [i].Init (scale [i], scale [j], scale [k]);

			if (noteInfo.Sharps[scale[i]]) {
				sharps [i] += "#";
			}

			chords[i].name = chordPrefix[i] + noteInfo.PitchNames [scale [i]] + sharps[i] + chordPostfix[i];
			chordNames [i] = chords [i].name;
		}
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

	}
		
}
