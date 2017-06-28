using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Iniciar : MonoBehaviour {

	public void Inicia()
	{
		SceneManager.LoadScene (1);
	}

	public void Creditos()
	{
		SceneManager.LoadScene (2);
	}	

	public void Sair()
	{
		Application.Quit();
	}
}
