using UnityEngine;
using System.Collections;

public class Drop : MonoBehaviour
{
	public Hero hero;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		Destroy (gameObject);
	}
}

