using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {


	public  Text  hudTimer;
	public  float maxTime      = 120;
	public  bool  increaseTime = true;
	private float timer;
	private int   sign;

	void Start() {
		if (increaseTime) {
			timer = 0;
			sign  = 1;
		} else {
			timer = maxTime;
			sign  = -1;
		}
		hudTimer.text = "Zero";
	}


	void Update() {
		timer += sign * Time.deltaTime;
		int minutes   = (int)(timer / 60);
		int seconds   = (int)(timer % 60);
		hudTimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);

		if(timer < 0)
		{
			TempoCabo();
		}
	} 

	void TempoCabo() {
		// SceneManager.LoadScene(0);
		SceneManager.LoadScene (4);
	}
}
		
