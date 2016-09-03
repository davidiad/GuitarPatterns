using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Fretboard : MonoBehaviour {

	public enum PieceType 
	{
		NORMAL,
		COUNT,
	};

	[System.Serializable]

	public struct PiecePrefab 
	{
		public PieceType type;
		public GameObject prefab;
	};

	public int xDim;
	public int yDim;

	public PiecePrefab[] piecePrefabs;
	public GameObject backgroundPrefab;

	private Dictionary<PieceType, GameObject> piecePrefabDict;

	private Note[,] notes;
	public string[] noteArray;
	// Use this for initialization
	void Start () {
		//noteArray = ["A", "A#", "B", "C", "C#", 
		piecePrefabDict = new Dictionary <PieceType, GameObject> ();

		for (int i = 0; i < piecePrefabs.Length; i++) {
			if (!piecePrefabDict.ContainsKey (piecePrefabs [i].type)) {
				piecePrefabDict.Add (piecePrefabs [i].type, piecePrefabs [i].prefab);
			}
		}

		for (int x = 0; x < xDim; x++) {
			for (int y = 0; y < yDim; y++) {
				
				GameObject background = (GameObject)Instantiate (backgroundPrefab, new Vector3 (3.01f * x + 3.0f + 0, 0, y + 0.8f), Quaternion.identity);
				background.transform.parent = transform;
			}
		}

		notes = new Note[xDim, yDim];
		int octave = 2;

		for (int x = 0; x < xDim; x++) {
			for (int y = 0; y < yDim; y++) {
				GameObject newNote = (GameObject)Instantiate (piecePrefabDict [PieceType.NORMAL], new Vector3 (3.01f * x, 0, 1.3f * y), Quaternion.identity);
				newNote.name = "Notes(" + x + "," + y + ")";
				newNote.transform.parent = transform;

				notes[x, y] = newNote.GetComponent<Note>();

				int pitchShift = 0;

				switch (y) {
				case 0: // low E string
					pitchShift = 7;
					if (x > 3) {
						octave = 3;
					} else { octave = 2; }
					break;
				case 1: // A string
					pitchShift = 0;
					octave = 3;
					break;
				case 2: // D string
					pitchShift = 5;
					if (x > 5) {octave = 4;}
					else {octave = 3;}
					break;
				case 3: // G string
					pitchShift = 10;
					if (x == 0) {octave = 3;}
					else {octave = 4;}
					break;
				case 4: // B string
					pitchShift = 2;
					if (x > 8) {octave = 5;}
					else {octave = 4;}
					break;
				case 5: // high E string
					pitchShift = 7;
					if (x > 3) {
						octave = 5;
					} else {
						octave = 4;
					}
					break;
				default: // either E string
					pitchShift = 8;
					break;
				}
				notes[x,y].Init(this, PieceType.NORMAL, pitchShift + x, octave);

				//notes [x, y].NoteComponent.SetPitch ((Note.PitchType)Random.Range (0, notes [x, y].NoteComponent.NumPitches));
			}
		}
	}

	void Update() {
		SetChord (10);
		//ResetNoteColors ();
	}

	void SetChord(int _chordID) {
		for (int x = 0; x < xDim; x++) {
			for (int y = 0; y < yDim; y++) {
				if ( notes [x, y].noteIdentifer != 10 && notes [x, y].noteIdentifer != 2 && notes [x, y].noteIdentifer != 5  )
				{
					notes [x, y].noteText.color = Color.gray;
				}
			}
		}
	}

	void ResetNoteColors() {
		for (int x = 0; x < xDim; x++) {
			for (int y = 0; y < yDim; y++) {
				notes [x, y].noteText.color = Color.HSVToRGB (notes[x, y].noteColor, 1.0f, 1.0f);
			}
		}
	}

//	Vector2 GetWorldPosition(int x, int y) {
//		return new Vector2 (transform.position.x - xDim / 2.0f + x, transform.position.y + yDim / 2.0f - y);
//
//	}
	Vector3 GetWorldPosition(int x, int y) {
		return new Vector3 (transform.position.x - xDim / 2.0f + (3.01f * x), 0.0f, transform.position.y + yDim / 2.0f - y);

	}


	

}
 