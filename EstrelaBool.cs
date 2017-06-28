using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstrelaBool : MonoBehaviour
{
	public GameObject  bulletPrefab;
	public  Transform  bulletsContainer;
	private int        currentBulletIndex;
	private List<EstrelaController> bullets;


	public void Start() 
	{
		bullets          = new List<EstrelaController>();
		bullets.Capacity = 20;
		AddBulletsToThePool();

	}
		
	private void AddBulletsToThePool() 
	{
		for (int i = 0; i < 50; i++) {
			var go = Instantiate(bulletPrefab);
			go.SetActive(false);
			go.transform.parent = bulletsContainer;
			bullets.Add(go.GetComponent<EstrelaController>());
		}
	}

	public EstrelaController GetBullet() 
	{
		EstrelaController c = bullets[currentBulletIndex];
		currentBulletIndex = (currentBulletIndex + 1) % bullets.Count;
		return c;
	}
}

