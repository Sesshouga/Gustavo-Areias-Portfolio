using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Azul : MonoBehaviour 
{

	public AzulMaior az;
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
	public void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.CompareTag("Missil")) {
			az.azul++;
			gameObject.SetActive(false);	
		}

	}
	IEnumerator Reinicia()
	{
		yield return new WaitForSecondsRealtime(2f);
		Reload = true; 
	}

}
