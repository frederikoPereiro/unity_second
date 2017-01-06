using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour
{
	public PaddleScript paddle;
	public bool gameStarted = false;
	private Vector3 paddleVector;


	// Use this for initialization
	void Start ()
	{
		paddleVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(!gameStarted)
		{
			this.transform.position = paddle.transform.position + paddleVector;
			if(Input.GetMouseButtonDown(0))
			{
				gameStarted = true;
				this.GetComponent<Rigidbody2D> ().velocity = new Vector3 (2f, 10f);
			}
		}
	
	}
}

