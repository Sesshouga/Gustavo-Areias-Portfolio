﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstrelaController : MonoBehaviour {

	private static  Quaternion zero = Quaternion.identity;


	private Transform   trans;
	private Rigidbody2D rb;


	public void Awake() {
		trans = GetComponent<Transform>();
		rb    = GetComponent<Rigidbody2D>();
	}


	public void SetInMotion(Vector3 pos) {
		ToggleActive(true);
		trans.position = pos;
		rb.AddForce(Vector2.left * 500);
//		rb.AddForce(Vector2.down * 500);
	}


	public bool IsActive() { return gameObject.activeInHierarchy; }


	public void ToggleActive(bool c) {
		gameObject.SetActive(c);
	}


	public void OnTriggerEnter2D(Collider2D hit) {
//		if (hit.gameObject.CompareTag("Paredes")) {
//			ToggleActive(false);
//			return;
//		} 

		//		if (hit.gameObject.CompareTag("Missil")) {
		//			ToggleActive(false);
		//			return;
		//		} 
		//		if (hit.gameObject.CompareTag("Tiro")) {
		//			ToggleActive(false);
		//			return;
		//		} 

		//		if (hit.gameObject.CompareTag("BalaInimiga")) {
		//			hit.gameObject.GetComponent<EnemyBulletController>().ToggleActive(false);
		//			ToggleActive(false);
		//			return;
		//		}


		if (hit.gameObject.CompareTag("Player")) {
			ToggleActive(false);
			return;
		}
	}

	void OnBecameInvisible ()
	{
		ToggleActive(false);
	}
}