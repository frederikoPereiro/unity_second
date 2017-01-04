using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {
	//create game object

	// Use this for initialization
	void Start () {

	}
		
	// Update is called once per frame
	void Update () {
		moveBucket ();


	}

	private void moveBucket()
	{
		Vector3 positionBucket = new Vector3 (this.transform.position.x, this.transform.position.y, 0);
		float mouseCurrentPositionX = Input.mousePosition.x / Screen.width * 10;
		positionBucket.x = Mathf.Clamp (mouseCurrentPositionX, -4.24f, 4.24f);
		this.transform.position = positionBucket;
	}
		
}
