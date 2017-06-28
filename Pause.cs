using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using System.Collections;

public class Pause : MonoBehaviour {
	private bool paused;
	private float originalFixedTime;
	public GameObject pauseMenu;
	public CharacterController fpc;

	// Use this for initialization
	void Start () {
		paused = false;
		originalFixedTime = Time.fixedDeltaTime;
		pauseMenu.SetActive (false);
	}

	public void PauseGame(){
		Time.timeScale = 0;
		Time.fixedDeltaTime = 0;
		pauseMenu.SetActive (true);
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
		fpc.enabled = false;
	}

	public void UnPauseGame(){
		Time.timeScale = 1;
		Time.fixedDeltaTime = originalFixedTime;
		pauseMenu.SetActive (false);
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
		fpc.enabled = true;
	}

	public void ResetGame(){
		UnPauseGame ();
		SceneManager.LoadScene (1);
	}

	public void QuitGame(){
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.QuitGame();
		#endif
	}
	// Update is called once per frame
	public void Update() {
		if (Input.GetKeyDown(KeyCode.P))
		{
			paused = !paused;
			if (paused)
			{
				PauseGame();
			}
			else if (!paused)
			{
				UnPauseGame();
			}

		}
	}
}