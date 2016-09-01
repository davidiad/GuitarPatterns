using UnityEngine;
using System.Collections;


public class GuitarNoteClips : MonoBehaviour {

	[System.Serializable]

	public struct AudioClips 
	{
		public AudioClip clip;
	};

	public AudioClip[] audioClips;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
