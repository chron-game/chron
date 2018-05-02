using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;

	public GameObject pauseMenuUI;
	public GameObject pauseOptions;

	void Awake() {
		pauseMenuUI.SetActive (false);
		pauseOptions.SetActive (false);
		GameIsPaused = false;
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (GameIsPaused) {
				Resume ();
			} else {
				Pause ();
			}
		}
	}

	public void Resume() {
		pauseMenuUI.SetActive (false);
		pauseOptions.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;
		Cursor.visible = false;
	}

	void Pause() {
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GameIsPaused = true;
		Cursor.visible = true;
	}

	public void LoadMenu() {
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Main Menu");
	}

	public void OptionsMenu() {
		Time.timeScale = 1f;

	}

	public void QuitGame() {
		Application.Quit();
	}
}
