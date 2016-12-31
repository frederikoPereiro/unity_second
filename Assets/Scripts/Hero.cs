using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

	private Vector3 positionOfBucket;
	private int firstElement = 0;
	private int secondElement = 0;
	private int thirdElement = 0;
	private int value = 5;

	// Use this for initialization
	void Start () {
		InsteadClass firstObject = new InsteadClass (value);
		firstObject.a = 1;
		int a = firstObject.getValue ();
		firstObject.print (a);
	}

	// Update is called once per frame
	void Update () {
		positionOfBucket = new Vector3 (-1, 3, 0);
		this.transform.position = positionOfBucket;
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

	private class InsteadClass
	{
		public int a;
		private int b;

		//the constructor
		public InsteadClass(int a)
		{
			setValue(a);
		}

		private void setValue(int value)
		{
			b = value;
		}
		public int getValue()
		{
			return b;
		}
		//the method
		public void print(int a)
		{
			string logMessage = "variable is " + a;
			Debug.Log (logMessage);
		}


	}

}
