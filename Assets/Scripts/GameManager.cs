using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//status of game
public enum GameStatus
{
	NotStart,
	Played,
	Completed,
	Failed
}
//call of audio source
[RequireComponent(typeof(AudioSource))]

public class GameManager : MonoBehaviour {

	public AudioClip startClip;
	public AudioClip failedClip;

	private GameStatus currentState = GameStatus.NotStart;

	private PaddleScript paddle;
	private BallScript[] allBalls;
	private StarClass[] allStars;

	//set time
	public float Timer = 0f;
	private int minutes;
	private int seconds;
	public string formattedTime;

	// Use this for initialization
	void Start () {
		//start time
		Time.timeScale = 1;

		//find all objects of different types on a screen
//		allStars = FindObjectsOfType (typeof(StarClass)) as StarClass[];
		allBalls = FindObjectsOfType (typeof(BallScript)) as BallScript[];	//to find all balls
//		Debug.Log (allBalls.Length);
//		paddle = GameObject.FindObjectOfType<PaddleScript> ();
		SwitchState(GameStatus.NotStart); 
	}
	
	// Update is called once per frame
	void Update () {
		switch (currentState) {
		case GameStatus.NotStart:
			if (Input.GetMouseButtonDown (0)) {
				SwitchState (GameStatus.Played);
			}
			break;
		case GameStatus.Played:
			Timer += Time.deltaTime;
			minutes = Mathf.FloorToInt (Timer / 60f);
			seconds = Mathf.FloorToInt (Timer - minutes * 50);
			formattedTime = string.Format ("{0:0}:{1:00}", minutes, seconds);
//			Debug.Log ("played");
//			bool allBlocksDestroyed = false;
			if (FindObjectOfType (typeof(BallScript))==null) {
				Debug.Log ("failled");
				SwitchState (GameStatus.Failed);
			}
//			if (allBlocksDestroyed) {
//				SwitchState (GameStatus.Completed);
//			}
			break;
		case GameStatus.Failed:
			Debug.Log ("failed");
			break;
		case GameStatus.Completed:
			break;
//			bool allBlockDestroyedFinal = false;
//			BallScript[] others = FindObjectsOfType (typeof(BallScript)) as BallScript[];
//			foreach (BallScript other in others) {
//				Destroy (other.gameObject);
//			}
//			break;
		}
	}
	//game state
	public void SwitchState(GameStatus newState)
	{
		currentState = newState;
		switch(currentState)
		{
		default:
		case GameStatus.NotStart:
			break;
		case GameStatus.Played:
			GetComponent<AudioSource> ().PlayOneShot (startClip);
			break;
		case GameStatus.Completed:
			GetComponent<AudioSource> ().PlayOneShot (startClip);
			break;
		case GameStatus.Failed:
			GetComponent<AudioSource> ().PlayOneShot (failedClip);
			Debug.Log ("failed sount");
			break;
		}
	}
}
