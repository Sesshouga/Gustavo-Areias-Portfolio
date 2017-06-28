﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour 
{

	public GameObject camera;
	public GameObject player;

	public bool trigger = false;

	public Laranja lar;

	public void NextPhase()
	{
		camera.transform.position = new Vector2(camera.transform.position.x+7f, camera.transform.position.y);
		player.transform.position = new Vector2(player.transform.position.x+7f, player.transform.position.y);
	}
}