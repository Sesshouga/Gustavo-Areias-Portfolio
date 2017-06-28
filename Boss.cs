using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour 
{

	public  float       speed    = 5;
	public  float maxDistance = 0.5F;
	public  Transform[] waypoints;
	private int         currentWayPoint;
	private Rigidbody2D   rb;
	private Transform trans;
	public int vida = 3;

	public Transform firePoint;
	public GameObject Missil;
	public bool Tiro;
	public BossMeteorPool pool;
	public bool Reload;
	private float timer = 4f;
	private IEnumerator coroutine;

	public void Start() 
	{
		currentWayPoint = 0;
		rb    = GetComponent<Rigidbody2D>();
		trans = GetComponent<Transform>();
		Reload = true;
	}

	public void FixedUpdate() 
	{
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
		}

	}

	public void OnTriggerEnter2D(Collider2D hit)
	{
		if (hit.CompareTag ("Missil")) 
		{
			vida--;
			if (vida == 0) 
			{
				SceneManager.LoadScene (5);
			}
				
		}
	}
	IEnumerator Reinicia()
	{
		yield return new WaitForSecondsRealtime(2f);
		Reload = true;
	}

}
