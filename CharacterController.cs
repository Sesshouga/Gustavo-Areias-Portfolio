using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour {

	public  Vector2        jumpForce = new Vector2(0, 300);
	//public  Camera         myCam;
	private Rigidbody2D    rb;
	private Transform      trans;
	private Vector3        originalPos;
	private Vector2        zeroVector2;
	public Transform firePoint;
	public GameObject Missil;
	public bool Tiro;
	public PlayerBulltetPool pool;


	//public PlayerBulltetPool pool;


	//public GameObject Missil;

	public void Start() {
		trans       = GetComponent<Transform>();
		rb          = GetComponent<Rigidbody2D>();
		originalPos = trans.position;
		zeroVector2 = new Vector2(0, 0);

	}

	public void ApplyForce() {
		rb.velocity = Vector2.zero;
		rb.AddForce(jumpForce);
	}

	/*	public void Update() {
		if (Input.GetKeyDown(KeyCode.Space)) ApplyForce();

		if (Input.GetKeyDown (KeyCode.A)) 
		{
			GetComponent<PlayerBulltetPool>;
		}
			
		Vector2 screenPosition = myCam.WorldToScreenPoint(trans.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0) Die();
}*/

	public void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Meteoro")
		{
			Die ();
		}
		if (other.tag == "Tiro")
		{
			Die ();
		}
		if (other.tag == "Estrela")
		{
			Die ();
		}
	}

	void Die() {
		// SceneManager.LoadScene(0);
		SceneManager.LoadScene (3);
	}

	public void Atira()
	{
		var b = pool.GetBullet();
		b.SetInMotion(firePoint.position);
	}
}
