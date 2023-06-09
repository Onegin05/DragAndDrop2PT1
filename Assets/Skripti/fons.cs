using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fons : MonoBehaviour {

	public void UzSakumu(){
		SceneManager.LoadScene ("sakum menu", LoadSceneMode.Single);
	}

	public void PilsetasKarte(){
		SceneManager.LoadScene ("PilsetasKarte", LoadSceneMode.Single);
	}

	public void Apturet(){
		Application.Quit ();
	}
}