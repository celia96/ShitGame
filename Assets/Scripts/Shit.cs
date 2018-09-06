using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shit : MonoBehaviour {

	[Tooltip("The individual sprites of the animation")]
	public Sprite[] frames;
	[Tooltip("How fast does the animation play")]
	public float framesPerSecond;
	SpriteRenderer spriteRenderer;
	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
		// StartCoroutine(WaitToDestroy());

		// instead of using WaitToDestroy, create this Coroutine that will play back a sprite animation from frames and destroy the object afterwards
		StartCoroutine(PlayAnimation());
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
		if (other.CompareTag ("floor1")) {
			OnHit ();

		}
	}

	IEnumerator PlayAnimation() {
		int currentFrameIndex = 0;
		while (currentFrameIndex < frames.Length) {
			spriteRenderer.sprite = frames [currentFrameIndex];
			yield return new WaitForSeconds(1f / framesPerSecond);
			currentFrameIndex++;
		}

	}

	
}
