using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour {
	private BallScript ballObject;

	IEnumerator Pause()
	{
		yield return new WaitForSeconds (2);
		ballObject = GameObject.FindObjectOfType<BallScript> ();
		ballObject.gameStarted = false;
		Application.LoadLevel (Application.loadedLevel);
	}

	void OnTriggerEnter2D(Collider2D trigger)
	{
		StartCoroutine (Pause ());
	}






	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
