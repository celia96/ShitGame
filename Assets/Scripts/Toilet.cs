using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toilet : MonoBehaviour {

	bool left = false;
	private int score;
	public float speed; 
	private Vector3 direction;
	public AudioSource sploosh; 
	// public AudioSource nope; 


	// Use this for initialization
	void Start () {
		score = 0;
		direction = Vector3.right;
		sploosh = GetComponent<AudioSource> ();
		// nope = GetComponent<AudioSource> ();
		// start_position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		

		if (Input.GetKeyDown (KeyCode.Space)) {
			if (left) {
				left = false;
				direction = Vector3.right;
			}
			else {
				left = true;
				direction = Vector3.left;

			}

		}
		transform.position += direction * speed * Time.deltaTime;


	}


	void OnTriggerEnter2D (Collider2D other) {
		if (other.CompareTag ("shit")) {

			Shit shit = other.GetComponent<Shit> ();
			shit.OnHit ();
			sploosh.Play ();
			score++;
			if (score % 5 == 0 ) {
				Shit_Bar.instance.IncreaseBar ();

			}

		}


		if (other.CompareTag ("other stuff")) {
			OtherStuff stuff = other.GetComponent<OtherStuff> ();
			stuff.OnHit ();
			// nope.Play ();
			Shit_Bar.instance.DecreaseBar ();

		}
			
	}

	void OnTriggerExit2D (Collider2D other) {
		if (other.CompareTag ("wall")) {

			if (left) {
				direction = Vector3.right;
				left = false; 
			} else {
				direction = Vector3.left;
				left = true;
			}

		}
	
	}
}
