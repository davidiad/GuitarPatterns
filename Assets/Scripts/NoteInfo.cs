using UnityEngine;
using System.Collections;

public enum PitchName
{
	A, B, C, D, E, F, G, COUNT 
};

public class NoteInfo : MonoBehaviour {


	private PitchName[] pitchNames;
	private bool[] sharps;
	private int[] identifiers;
	private string[] noteRichTexts;

	public PitchName[] PitchNames
	{
		get { return pitchNames; }
	}

	public bool[] Sharps
	{
		get { return sharps; }
	}

	public int[] Identifiers
	{
		get { return identifiers; }
	}


	public string[] NoteRichTexts
	{
		get { return noteRichTexts; }
	}



	void Awake () {
		pitchNames  = new PitchName[] {PitchName.A, PitchName.A, PitchName.B, PitchName.C, PitchName.C, PitchName.D, PitchName.D, PitchName.E, PitchName.F, PitchName.F, PitchName.G, PitchName.G};
		sharps = new bool[] {false, true, false, false, true, false, true, false, false, true, false, true};
		identifiers = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
		noteRichTexts = new string[] { "A", "A", "B", "C", "C", "D", "D", "E", "F", "F", "G", "G" };
	}

}
