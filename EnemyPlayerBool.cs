using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayerBool : MonoBehaviour {

	public GameObject  bulletPrefab;
	public  Transform  bulletsContainer;
	private int        currentBulletIndex;
	private List<EnemyBulletController> bullets;


	public void Start() {
		bullets          = new List<EnemyBulletController>();
		bullets.Capacity = 79;
		AddBulletsToThePool();

	}

	//	void Update ()
	//	{
	//		print(bullets.Count);
	//	}

	#region Regular Bullets
	private void AddBulletsToThePool() {
		for (int i = 0; i < 50; i++) {
			var go = Instantiate(bulletPrefab);
			go.SetActive(false);
			go.transform.parent = bulletsContainer;
			bullets.Add(go.GetComponent<EnemyBulletController>());
		}
	}

	public EnemyBulletController GetBullet() {
		EnemyBulletController c = bullets[currentBulletIndex];
		//		if (b.IsActive()) {
		//			print("Number of PlayerBullets not enough");
		//			return null;
		//		}

		currentBulletIndex = (currentBulletIndex + 1) % bullets.Count;
		return c;
	}
	#endregion
}
