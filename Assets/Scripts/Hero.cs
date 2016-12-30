using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

	private int a = 5;
	private int b = 6;

	// Use this for initialization
	void Start () {
		print (myFunction (a, b));
	}

	// Update is called once per frame
	void Update () {
		
	}

	int myFunction(int first, int second)
	{
		return first+second;
	}



}
