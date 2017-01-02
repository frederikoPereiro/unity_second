using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

	private Vector3 positionOfBucket;
	private int firstElement = 0;
	private int secondElement = 0;
	private int thirdElement = 0;
	private int value = 5;
	private int valueOne = 6;

	private float xPosition = -1.0f;
	private float yPosition = 3.0f;
	private const float ZPOSITION = 0.0f;

	// Use this for initialization
	void Start () {


	}

	private void rotationMethod()
	{
		this.transform.rotation = Quaternion.Euler (new Vector3 (0, 0, Input.mousePosition.x));
	}
	// Update is called once per frame
	void Update () {
//		positionOfBucket = new Vector3 (xPosition, yPosition, ZPOSITION);
//		this.transform.position = positionOfBucket;
		rotationMethod ();
	}

	private void FunctionOne()
	{
		if(secondElement > firstElement)
		{
			thirdElement = secondElement + firstElement;
			Debug.Log ("element = " + thirdElement);
		}
		else
		{
			Debug.Log (firstElement);
		}
	}
		
}
