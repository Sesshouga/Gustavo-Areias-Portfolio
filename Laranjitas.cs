using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laranjitas : MonoBehaviour 
{

	public int laranja = 0;
	public CameraScript cam;

	public void FixedUpdate() 
	{
		if(laranja == 7)
		{
			cam.NextPhase();
			gameObject.SetActive(false);
		}
	}
}
