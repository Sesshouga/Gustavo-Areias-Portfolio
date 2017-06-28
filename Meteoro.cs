using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteoro : MonoBehaviour 
{

	public float movementSpeed = 5.0f;
	private Transform trans;

	public void Awake () {
		trans = GetComponent<Transform>();
	}

	void Update () {
		trans.Translate(transform.right * Time.deltaTime * movementSpeed);
	}	

	public void OnTriggerEnter2D(Collider2D fim) {
	}
}
