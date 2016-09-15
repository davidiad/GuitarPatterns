using UnityEngine;
using System.Collections;

public class ChordShape : MonoBehaviour {

	public Vector2[] chordPoints;
	public Fretboard fretboard;
	private Vector2 pt0;

	// Use this for initialization
	void Awake () {

	}

	void Start () {
		//StartCoroutine(Example());
		//fretboard = GameObject.FindGameObjectWithTag ("Fretboard").GetComponent<Fretboard> ();
		//Debug.Log("F: " + fretboard.notes[3, 0]);
		//float xpos = fretboard.notes [3, 0].transform.position.x;
		//float ypos = fretboard.notes [3, 0].transform.position.y;
		pt0 = new Vector2 (13f, 9.5f);
		Vector2 pt1 = new Vector2 (13, 0f);
		Vector2 pt2 = new Vector2 (8.6f, 1.9f);


		chordPoints = new Vector2[] { pt0, pt1, pt2};
	}

	IEnumerator Example() {
		print(Time.time);
		yield return new WaitForSeconds(3);
		print(Time.time);
	}
}

