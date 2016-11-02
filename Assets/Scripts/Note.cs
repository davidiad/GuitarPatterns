using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Note : MonoBehaviour {

		
	public PitchName notePitch;
	public bool sharp;
	public int noteIdentifer;
	public string noteRichText;
	public float noteColor;
		
	public float pitchAdjust;
	private NoteInfo noteInfo;

	public AudioClip clip;
	public GuitarNoteClips clips; // replace with just one clip, would be better, use less resources
	public AudioSource noteSource;
	public int octave;
	public int fret; // to make it easy to access given which fret it is on
	public bool isColored; // color of text is gray if false.

	private PitchName[] pitchNames  = new PitchName[] {PitchName.A, PitchName.A, PitchName.B, PitchName.C, PitchName.C, PitchName.D, PitchName.D, PitchName.E, PitchName.F, PitchName.F, PitchName.G, PitchName.G};
	//bool[] sharps = new bool[] {false, true, false, false, true, false, true, false, false, true, false, true};
	int[] identifiers = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
	//string[] noteRichTexts = new string[] { "A", "A", "B", "C", "C", "D", "D", "E", "F", "F", "G", "G" };

	bool[] gmajor = new bool[] {true, false, true, true, false, true, false, true, false, true, true, false};
	bool[] cmajor = new bool[] {true, false, true, true, false, true, false, true, true, false, true, false};


	private int notemeshText;

	private Fretboard fretboard;

	public Fretboard Fretboard
	{
		get { return fretboard; }
	}
		
	public enum PitchType
	{
		C, CSHARP, D, DSHARP, E, F, FSHARP, G, GSHARP, A, ASHARP, B, COUNT
	};
		

	[System.Serializable]
	public struct NoteMeshObject
	{
		public PitchType pitch;
		public GameObject noteObject;
		private string pitchText;
	};

	public NoteMeshObject[] noteMeshObjects;

	private PitchType pitch;

	public int NumPitches
	{
		get { return noteMeshObjects.Length; }
	}

	public TextMesh noteText; // should be the color ot the pitch?

	private Note noteComponent;

	public Note NoteComponent
	{
		get { return noteComponent; }
	}


	void Awake()
	{
		pitchAdjust = 1.05946f;
		noteComponent = GetComponent<Note> ();
		noteText = transform.Find("NoteText").GetComponent<TextMesh>();

		// careful -- seems like every clip will be in every note when only need one
		clips = GameObject.FindGameObjectWithTag ("GuitarNoteClips").GetComponent<GuitarNoteClips> (); 
		noteInfo = GameObject.FindGameObjectWithTag ("NoteInfo").GetComponent<NoteInfo> ();
	}

	// Use this for initialization
	void Start () {

		Renderer rend = GetComponent<Renderer>();
		rend.material.SetColor("_Color", Color.black);
	}
		

	public void colorOn(bool _isColored) {
		if (_isColored) {
			isColored = true;
			noteText.color = Color.HSVToRGB (noteColor, 1.0f, 1.0f);
		} else {
			isColored = false;
			noteText.color = Color.gray;
		}
	}

	// Init called from the GuitarString object that holds the notes
	public void Init (int _noteID, int _octave, int _fret) {
		notePitch = noteInfo.PitchNames [_noteID];
		sharp = noteInfo.Sharps [_noteID];
		noteIdentifer = noteInfo.Identifiers [_noteID];
		noteText.richText = true;
		noteRichText = "<b>" + noteInfo.NoteRichTexts [_noteID] + "</b>";
		if (noteInfo.Sharps [_noteID] == true) {
			noteRichText += "<size=38>#</size>";
		}

		noteColor = (_noteID / 12.0f) - 0.1f;
		noteText.text = noteRichText;
		noteText.color = Color.HSVToRGB (noteColor, 1.0f, 1.0f);
		isColored = true;

		fret = _fret;
		octave = _octave;
		noteSource = gameObject.GetComponent<AudioSource>();
		clip = clips.audioClips [octave];
		noteSource.clip = clip;
	}

	void OnMouseDown() {

		noteSource.priority = 0; // set the current/latest note being played to the highest priority in case of multiple notes playing
		noteSource.pitch = 1; //reset to default
		if (octave == 4) {
			noteSource.pitch = pitchAdjust; // compensating 1/2 step for source clip being G# rather than A (I think)
		}

		float pitchDiff = (float)(noteIdentifer);
		if (octave == 2) {
			pitchDiff -= 7.0f;
		}

		//TODO: Optimize by precalculating AndroidJNI putting into as lookup table
		noteSource.pitch = noteSource.pitch * Mathf.Pow(pitchAdjust, pitchDiff);

		noteSource.Play();
	}

}
