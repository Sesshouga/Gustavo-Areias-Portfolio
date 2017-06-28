using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laranja : MonoBehaviour {

	public Laranjitas lar;
	public CameraScript cam;

	public  float       speed    = 5;
	public  float maxDistance = 0.5F;
	public  Transform[] waypoints;
	private int         currentWayPoint;
	private Rigidbody2D   rb;
	private Transform trans;

	public void Start() {
		currentWayPoint = 0;
		rb    = GetComponent<Rigidbody2D>();
		trans = GetComponent<Transform>();
	}

	public void FixedUpdate() {
		var dir = waypoints[currentWayPoint].position.y - trans.position.y;

		if (Mathf.Abs(dir) < maxDistance) {
			currentWayPoint = (currentWayPoint + 1) % waypoints.Length;
		} else {
			rb.MovePosition(rb.position + Mathf.Sign(dir) * Vector2.up * speed * Time.deltaTime);
		}


	}
	public void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("Missil")) {
			lar.laranja++;
			gameObject.SetActive(false);	
		}

		/*if(laranja == 0);
		{
			cam.NextPhase();
		}*/
	}
	//colocar o script enemy normal nos carinhas e criar um script laranja soh pro pai


}
