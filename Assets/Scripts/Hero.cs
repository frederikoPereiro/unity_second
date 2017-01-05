using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

	private const float Z_POSITION = 0;

	// Use this for initialization
	void Start () {

	}
		
	// Update is called once per frame
	void Update () {
		moveBucket ();

	}
	//move the bucket
	private void moveBucket()
	{
		Vector3 positionBucket = new Vector3 (-0.62f, this.transform.position.y, Z_POSITION);
		float currentMouseX = Input.mousePosition.x / Screen.width * 10;
		positionBucket.x = Mathf.Clamp (currentMouseX, -4.31f, 4.34f);
		this.transform.position = positionBucket;
	}
}
