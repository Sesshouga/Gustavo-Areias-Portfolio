using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AzulMaior : MonoBehaviour 
{

	public int azul = 0;
	public CameraScript cam;

	public void FixedUpdate() 
	{
		if(azul == 3)
		{
			cam.NextPhase();
			gameObject.SetActive(false);
		}
	}
}
