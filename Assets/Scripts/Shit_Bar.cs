using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shit_Bar : MonoBehaviour {


	public GameObject energy;

	public static Shit_Bar instance;

	// Use this for initialization
	void Start () {
		instance = this;
		energy.transform.localScale =  new Vector3 (0.02f, 0.52f, 1);
	}
	
	// Update is called once per frame
	void Update () {
		if (energy.transform.localScale.x <= 0) {
			// print ("Lose");
			GameManager.instance.GameOver ();
			Time.timeScale = 0; // Freeze the game;
			//Application.LoadLevel(Application.loadedLevel);

		}
		if (energy.transform.localScale.x >= 0.27f || Input.GetKeyDown(KeyCode.A)) {
			// print ("Win");
			GameManager.instance.Win ();
			Time.timeScale = 0; // Freeze the game;
			//Application.LoadLevel(Application.loadedLevel);
			// GameManager.instance.RestartTheGame();

		}

		// energy.transform.position = new Vector3 (-8.78f, -3.46f, 0);

	}



	public void IncreaseBar () {
		energy.transform.localScale +=  new Vector3 (0.02f, 0, 0);

	}

	public void DecreaseBar () {
		energy.transform.localScale -=  new Vector3 (0.01f, 0, 0);

	}
}
