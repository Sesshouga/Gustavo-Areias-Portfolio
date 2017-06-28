using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public GameObject camera;
	public GameObject player;
/*	public GameObject inimigo1;
	public GameObject inimigo2;
	public float moveSpeed = 10f;
	public bool movimento1 = false;
	public bool movimento2 = false;
	public bool movimento3 = false;
	public bool movimento4 = false;*/
	public bool trigger = false;

	public Laranja lar;

/*	void Awake () {
		lar = GetComponent<Laranja> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (movimento1 == true) {
			camera.transform.position = new Vector2 (6.7f, 0);
			player.transform.position = new Vector2 (1.5f, 0);
			movimento1 = false;
			print("False");
			//Ficando travado pq eh update, fazer isso no script do inimigo no ontriggerenter/collider
		}

		if (movimento2 == true) 
		{
			camera.transform.position = new Vector2(18.1f,0);
			player.transform.position = new Vector2(12.5f,0);
		}

		if (movimento3 == true) 
		{
			camera.transform.position = new Vector2(29.6f,0);
			player.transform.position = new Vector2(24.1f,0);
		}
			
	}*/

	public void NextPhase()
	{
		camera.transform.position = new Vector2(camera.transform.position.x+7f, camera.transform.position.y);
		player.transform.position = new Vector2(player.transform.position.x+7f, player.transform.position.y);
	}
}