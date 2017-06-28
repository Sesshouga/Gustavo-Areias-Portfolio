using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public CameraScript cam;

	public  float       speed    = 5;
	public  float maxDistance = 0.5F;
	public  Transform[] waypoints;
	private int         currentWayPoint;
	private Rigidbody2D   rb;
	private Transform trans;

	public Transform firePoint;
	public GameObject Missil;
	public bool Tiro;
	public EnemyPlayerBool pool;
	public bool Reload;
	private float timer = 2f;
	private IEnumerator coroutine;

	public void Start() {
		currentWayPoint = 0;
		rb    = GetComponent<Rigidbody2D>();
		trans = GetComponent<Transform>();
		Reload = true;
//		coroutine = WaitForSeconds(2.0f);
//		StartCoroutine(coroutine);
	}

	public void FixedUpdate() {
		var dir = waypoints[currentWayPoint].position.y - trans.position.y;

		if (Mathf.Abs(dir) < maxDistance) {
			currentWayPoint = (currentWayPoint + 1) % waypoints.Length;
		} else {
			rb.MovePosition(rb.position + Mathf.Sign(dir) * Vector2.up * speed * Time.deltaTime);
		}

		if(Reload == true)
		{
			var c = pool.GetBullet();
			c.SetInMotion(firePoint.position);
			Reload = false;
			StartCoroutine( Reinicia());
			//Attack();
		}
	
	}

	public void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("Missil")) {
			cam.NextPhase();
			gameObject.SetActive(false);
		}
	}
	IEnumerator Reinicia()
	{
		//yield return StartCoroutine(WaitForSeconds(2.0f));
		yield return new WaitForSecondsRealtime(1f);
		Reload = true;
	}
//	private IEnumerator WaitForSeconds()
//	{
//		while (true){
//		yield return new WaitForSeconds(2.0f);
//		Reload = true;
//		}
//		}
//	public void Attack()
//	{
//		timer -= Time.deltaTime;
//		if(timer <= 0)
//		{
//			Reload = true;
//		}
//	}
//	public void Atira()
//	{
//		var c = pool.GetBullet();
//		c.SetInMotion(firePoint.position);
//	}
}