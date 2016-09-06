using UnityEngine;
using System.Collections;

public class Chord : MonoBehaviour {

	public string name;
	//public Note[] notes;
	public int[] noteIDs;


	// Use this for initialization
	void Awake () {
		//notes = new Note[3]; // could be 4 or more notes
		noteIDs = new int[3];
	}
	
	// Update is called once per frame
	void Start () {
	
	}
}
