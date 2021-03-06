﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMeteorPool : MonoBehaviour 
{

	public GameObject  bulletPrefab;
	public  Transform  bulletsContainer;
	private int        currentBulletIndex;
	private List<BossMeteorController> bullets;

	public void Start() {
		bullets          = new List<BossMeteorController>();
		bullets.Capacity = 79;
		AddBulletsToThePool();

	}

	private void AddBulletsToThePool() {
		for (int i = 0; i < 50; i++) {
			var go = Instantiate(bulletPrefab);
			go.SetActive(false);
			go.transform.parent = bulletsContainer;
			bullets.Add(go.GetComponent<BossMeteorController>());
		}
	}

	public BossMeteorController GetBullet() {
		BossMeteorController c = bullets[currentBulletIndex];

		currentBulletIndex = (currentBulletIndex + 1) % bullets.Count;
		return c;
	}
}
