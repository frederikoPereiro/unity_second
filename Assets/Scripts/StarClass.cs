using UnityEngine;
using System.Collections;


public class StarClass : MonoBehaviour
{
	public int maxHits;
	public int timeHit;
	public AudioClip startClip;

	// Use this for initialization
	void Start ()
	{
		timeHit = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		timeHit++;
		if(timeHit == maxHits)
		{
			Destroy (gameObject);

		}
	}












}

