using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

	Vector3 positionOfBucket;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		positionOfBucket = new Vector3 (-1, 3, 0);
		this.transform.position = positionOfBucket;
	}




}
