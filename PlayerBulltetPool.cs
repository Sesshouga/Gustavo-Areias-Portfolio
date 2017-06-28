using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulltetPool : MonoBehaviour 
{

	public GameObject  bulletPrefab;
	public  Transform  bulletsContainer;
	private int        currentBulletIndex;
	private List<PlayerBulletController> bullets;


	public void Start() 
	{
		bullets          = new List<PlayerBulletController>();
		bullets.Capacity = 79;
		AddBulletsToThePool();

	}
		
	#region Regular Bullets
	private void AddBulletsToThePool() 
	{
		for (int i = 0; i < 79; i++) {
			var go = Instantiate(bulletPrefab);
			go.SetActive(false);
			go.transform.parent = bulletsContainer;
			bullets.Add(go.GetComponent<PlayerBulletController>());
		}
	}

	public PlayerBulletController GetBullet() 
	{
		PlayerBulletController b = bullets[currentBulletIndex];
		currentBulletIndex = (currentBulletIndex + 1) % bullets.Count;
		return b;
	}
	#endregion
}