using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

//	private int a = 5;
//	private int b = 6;

	Vector3 positionOfBucket;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		positionOfBucket = new Vector3 (-1, 3, 0);
		this.transform.position = positionOfBucket;
	}

	private int myFunction(int first, int second)
	{
		return first+second;
	}
		
	private void secondFunction()
	{
		int i = 0;
		while(i<10)
		{
			print ("i = " + i);
			i++;
		}
	}
}
