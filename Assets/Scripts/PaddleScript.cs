using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddleVector = new Vector3 (0.0f, this.transform.position.y, 0);
		float mousePositionX = Input.mousePosition.x / Screen.width * 10;
		paddleVector.x = Mathf.Clamp (mousePositionX, -4.0f, 4f);
		this.transform.position = paddleVector;
		
	}
}
