using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrela : MonoBehaviour 
{
	public Transform firePoint;
	public GameObject Missil;
	public bool Tiro;
	public EstrelaBool pool;
	public bool Reload;
	private float timer = 2f;
	private IEnumerator coroutine;

	public void start()
	{
		Reload = true;
	}

	public void FixedUpdate()
	{
		if (Reload == true) {
			var c = pool.GetBullet ();
			c.SetInMotion (firePoint.position);
			Reload = false;
			StartCoroutine (Reinicia ());
		}
	}

		IEnumerator Reinicia()
		{
			yield return new WaitForSecondsRealtime(2f);
			Reload = true;
		}
	
}
