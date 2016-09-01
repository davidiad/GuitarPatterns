using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Note : MonoBehaviour {

//	public enum PitchName
//	{
//		A, B, C, D, E, F, G, COUNT 
//	};

//	public struct NoteData {
//		public GameObject note;
//		//public PitchName notePitch;
////		public bool sharp;
////		public int noteIdentifer; // needed?
////		public string noteRichText;
//		public AudioClip clip;
//		public int octave;
//	};
		
	public PitchName notePitch;
	public bool sharp;
	public int noteIdentifer;
	public string noteRichText;
		
	public float pitchAdjust;
	//private NoteData noteData; // to be deprecated in favor of NoteInfo object
	private NoteInfo noteInfo;

	public AudioClip clip;
	public GuitarNoteClips clips; // replace with just one clip, would be better, use less resources
	public AudioSource noteSource;
	public int octave;

	private PitchName[] pitchNames  = new PitchName[] {PitchName.A, PitchName.A, PitchName.B, PitchName.C, PitchName.C, PitchName.D, PitchName.D, PitchName.E, PitchName.F, PitchName.F, PitchName.G, PitchName.G};
	//bool[] sharps = new bool[] {false, true, false, false, true, false, true, false, false, true, false, true};
	int[] identifiers = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
	//string[] noteRichTexts = new string[] { "A", "A", "B", "C", "C", "D", "D", "E", "F", "F", "G", "G" };

	bool[] gmajor = new bool[] {true, false, true, true, false, true, false, true, false, true, true, false};
		
	//public TextMesh noteTextMesh;

//	private int noteID;
//	public int NoteID
//	{
//		get { return noteID; }
//	}
	private int notemeshText;

	private Fretboard fretboard;

	public Fretboard Fretboard
	{
		get { return fretboard; }
	}

	private Fretboard.PieceType type;

	public Fretboard.PieceType Type
	{
		get { return type; }
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

//	public PitchType Pitch
//	{
//		get { return pitch; }
//		set { SetPitch (value); }
//	}

	public int NumPitches
	{
		get { return noteMeshObjects.Length; }
	}

	private TextMesh noteText; // should be the color ot the pitch?
	//private Dictionary<PitchType, NoteData> noteMeshDict;

	private Note noteComponent;

	public Note NoteComponent
	{
		get { return noteComponent; }
	}

//	void Awake()
//	{
//
//		movableComponent = GetComponent<MovablePiece> ();
//		colorComponent = GetComponent<ColorPiece> ();
//	}

	void Awake()
	{
		pitchAdjust = 1.05946f;
		noteComponent = GetComponent<Note> ();
		//note = transform.Find ("piece").GetComponent<SpriteRenderer> ();
		noteText = transform.Find("NoteText").GetComponent<TextMesh>();

		//noteMeshDict = new Dictionary<PitchType, NoteData> ();



//		for (int i = 0; i < 12; i++) {
//			if (!noteMeshDict.ContainsKey (NoteData[i].PitchName.A)) {
//				noteMeshDict.Add (NoteData [i].pitch, noteMeshObjects [i].noteObject);
//			}
//		}

		// careful -- seems like every clips will be in every note when only need one
		clips = GameObject.FindGameObjectWithTag ("GuitarNoteClips").GetComponent<GuitarNoteClips> (); 
		noteInfo = GameObject.FindGameObjectWithTag ("NoteInfo").GetComponent<NoteInfo> ();
	}

	// Use this for initialization
	void Start () {
		
//		noteSource = gameObject.AddComponent<AudioSource>();

		Renderer rend = GetComponent<Renderer>();
		//rend.material.shader = Shader.Find("_Color");
		rend.material.SetColor("_Color", Color.black);
		//Debug.Log ("THIS one is: " + pitch);
		//noteText.tex = "x";

		//noteText.color = Color.gray;
		//SetNote ();
	

		//noteTextMesh = this.gameObject.transform.GetChild(0);



		//noteData.note.SetActive (gmajor [noteIdentifer]);
		this.gameObject.SetActive(gmajor[noteIdentifer]);





	}


//	// Update is called once per frame
//	void Update () {
//		if (Input.GetKeyDown(KeyCode.C)) {
//			noteSource.PlayOneShot (noteSource.clip, 0.05f);
//		}
//	}

//	public void SetPitch(PitchType newPitch)
//	{
//		pitch = newPitch;
//
//		if (noteMeshDict.ContainsKey (newPitch)) {
//			//noteText.richText = noteMeshDict [newPitch];
//		}
//	}

//	private void SetNote() {
//		if (Pitch == PitchType.C) {
//			noteID = 0;
//			noteText.text = "<b>C</b>";
//			noteText.color = Color.red;
//
//		}
//		if (Pitch == PitchType.CSHARP) {
//			noteID = 1;
//			noteText.text = "<b>C</b><size=38>#</size>";
//			noteText.color = Color.yellow;
//		}
//		if (Pitch == PitchType.D) {
//			noteID = 2;
//			noteText.text = "<b>D</b>";
//			noteText.color = Color.magenta;
//		}
//		if (Pitch == PitchType.DSHARP) {
//			noteID = 3;
//			noteText.text = "<b>D</b><size=38>#</size>";
//			noteText.color = Color.green;
//		}
//		if (Pitch == PitchType.E) {
//			noteID = 4;
//			noteText.text = "<b>E</b>";
//			noteText.color = Color.magenta;
//		}
//		if (Pitch == PitchType.F) {
//			noteID = 5;
//			noteText.text = "<b>F</b>";
//			noteText.color = Color.magenta;
//		}
//		if (Pitch == PitchType.FSHARP) {
//			noteID = 6;
//			noteText.text = "<b>F</b><size=38>#</size>";
//			noteText.color = Color.green;
//		}
//		if (Pitch == PitchType.G) {
//			noteID = 7;
//			noteText.text = "<b>G</b>";
//			noteText.color = Color.white;
//		}
//		if (Pitch == PitchType.GSHARP) {
//			noteID = 8;
//			noteText.text = "<b>G</b><size=38>#</size>";
//			noteText.color = Color.green;
//		}
//		if (Pitch == PitchType.A) {
//			noteID = 9;
//			noteText.text = "<b>A</b>";
//			noteText.color = Color.magenta;
//		}
//		if (Pitch == PitchType.ASHARP) {
//			noteID = 10;
//			noteText.text = "<b>A</b><size=38>#</size>";
//			noteText.color = Color.green;
//		}
//		if (Pitch == PitchType.B) {
//			noteID = 11;
//			noteText.text = "<b>B</b>";
//			noteText.color = Color.blue;
//		}
//	}
		

	public void Init(Fretboard _fret, Fretboard.PieceType _type, int xValue, int _octave)
	{
		//noteData.note = transform.gameObject;
		int xpos = (xValue) % 12;
		fretboard = _fret;
		type = _type;
		//this.noteID = xpos;  // not needed?
		notePitch = noteInfo.PitchNames [xpos];
		sharp = noteInfo.Sharps [xpos];
		noteIdentifer = noteInfo.Identifiers [xpos];

		noteText.richText = true;
		noteRichText = "<b>" + noteInfo.NoteRichTexts [xpos] + "</b>";
		if (noteInfo.Sharps [xpos] == true) {
			noteRichText += "<size=38>#</size>";
		}

		float noteColor = (xpos / 12.0f) - 0.1f;
		noteText.text = noteRichText;
		noteText.color = Color.HSVToRGB (noteColor, 1.0f, 1.0f);

		noteSource = gameObject.GetComponent<AudioSource>();

		//noteData.clip = clips.audioClips [xpos];

//		if (_octave == 2) {
//			noteData.clip = clips.audioClips [0];
//		} else {
//			noteData.clip = clips.audioClips [1];
//		}
//
		clip = clips.audioClips [_octave];
		noteSource.clip = clip;

		octave = _octave; 

		 
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
