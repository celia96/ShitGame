using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cash : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnHit(){ 
		// the Instatiate function creates a new GameObject copy (clone) from a Prefab at a specific location and orientation.
		// Instantiate(explosionPrefab, transform.position, transform.rotation);
		Destroy(gameObject);
	}


	void OnTriggerEnter2D (Collider2D other) {
		// if the other object has the MainCamera tag, destroy the shits
		if (other.CompareTag ("MainCamera")) {
			print ("Camera hit");
			OnHit ();

		}
	}
}
