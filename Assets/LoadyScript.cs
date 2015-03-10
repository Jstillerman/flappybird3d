using UnityEngine;
using System.Collections;

public class LoadyScript : MonoBehaviour {
	TextMesh tm;
	// Use this for initialization
	void Start () {
		tm = GameObject.Find ("ScoreMesh").GetComponent<TextMesh> ();

	
	}
	
	// Update is called once per frame
	void Update () {

		if (Cardboard.SDK.CardboardTriggered) {
			Application.LoadLevel(1);
				}

		tm.text = "High Score: " + flappyScript.highscore;


	
	}
}
