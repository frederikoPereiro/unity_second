using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource), typeof(Animation))]

public class StarClass : MonoBehaviour
{
	public int maxHits;
	public int timeHit;
	private bool brickDestroyed = false;

	public AudioClip sound;
	public float PitchStep = 0.05f;
	public float MaxPitch = 1.3f;

	public static float pitch = 1;

	public bool fallDown = false;
	[HideInInspector]
	public bool BlockIsDestroyed = false;
	private Vector2 velocity = Vector2.zero;


	// Use this for initialization
	void Start ()
	{
		timeHit = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(fallDown && velocity!=Vector2.zero)
		{
			Vector2 pos = (Vector2)transform.position;
			pos += velocity * Time.deltaTime;
		}
	
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		timeHit++;
		if(timeHit == maxHits)
		{
			Destroy (gameObject);

		}
	}

	private IEnumerator OnCollisionExit2D(Collision2D c)
	{
		if(timeHit == maxHits)
		{
			GetComponent<Collider2D> ().enabled = false;
			GetComponent<Animation> ().Play ();
			yield return new WaitForSeconds (GetComponent<Animation> () ["newAnim"].length);
		}
	}
}

