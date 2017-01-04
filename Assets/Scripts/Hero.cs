using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {
	//create game object
	public GameObject heroObject;
	public GameObject dropObject;
	public SecondScript secondScript;

	private void rotationMethod()
	{
		this.transform.rotation = Quaternion.Euler (new Vector3 (0, 0, Input.mousePosition.x));
	}
		
	private void changeObjectColor()
	{
		Color col = Color.red;
		float Ax = heroObject.transform.position.x;
		float Bx = dropObject.transform.position.x;

		if(Ax < Bx)
		{
			col = Color.blue;
//			Debug.Log (Ax);
//			Debug.Log (Bx);
		}
		else
		{
			col = Color.red;
		}
		GetComponent<Renderer> ().material.color = col;
	}

	private void runawayLoopsMethod()
	{
		Debug.Log ("start ");
		for(;;)
		{
			Debug.Log ("before return");
			break;
		}
		Debug.Log ("outside for loops ");
	}

	public void findGameOnScene()
	{
		GameObject[] gameOnScreen = Object.FindObjectsOfType(typeof(GameObject)) as GameObject[];
		foreach(GameObject go in gameOnScreen)
		{
			Debug.Log (go);
		}
	}
		
	// Use this for initialization
	void Start () {
		runawayLoopsMethod ();
		findGameOnScene ();
	}
		
	// Update is called once per frame
	void Update () {
//		positionOfBucket = new Vector3 (xPosition, yPosition, ZPOSITION);
//		this.transform.position = positionOfBucket;
		rotationMethod ();
		changeObjectColor ();

	}
		
}
