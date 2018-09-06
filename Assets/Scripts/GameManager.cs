using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public GameObject losePanel;
	public GameObject winPanel;

	private AudioSource win;

	/// <summary>
	/// Use Awake to initialize the instance with the active script instance from the current scene.
	/// </summary>
	void Awake(){
		instance = this;
		losePanel.SetActive(false);
		winPanel.SetActive (false);
		win = GetComponent<AudioSource> ();
		Time.timeScale = 1;

	}
	/*
	/// <summary>
	/// Reloads the current scene with some delay in seconds.
	/// </summary>
	/// <param name="seconds">Seconds.</param>
	public void RestartTheGameAfterSeconds(float seconds){
		StartCoroutine (LoadSceneAfterSeconds (seconds));
	}

	// Coroutine to start the game again
	IEnumerator LoadSceneAfterSeconds(float seconds){
		yield return new WaitForSeconds (seconds);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
	*/
	/// <summary>
	/// This GameManager will check for input to restart the scene
	/// </summary>
	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Time.timeScale = 1;
			RestartTheGame ();
			// Time.timeScale = 1;
		}


	}

	/// <summary>
	/// Reloads the current scene.
	/// </summary>
	public void RestartTheGame(){
		
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	public void GameOver () {
		losePanel.SetActive(true);
	}

	public void Win () {
		win.Play ();
		winPanel.SetActive(true);

	}


}
